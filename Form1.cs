using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using ReportPreviewer.Properties;

namespace ReportPreviewer
{
    public partial class PunksNotDead : Form
    {
        private Config _config;
        public PunksNotDead() {
            InitializeComponent();
            this.FormClosing += OnFormClosing;
            this.Load += PunksNotDead_Load;
        }

        void PunksNotDead_Load(object sender, EventArgs e) {
            var defaults = Settings.Default;
            this.Location = (Point)defaults["Location"];
            this.Size = (Size)defaults["Size"];
            var dataSources =
                JsonConvert.DeserializeObject<List<Config.ReportDataSource>>(defaults["Queries"].ToString());
            _config = new Config(defaults["ReportPath"].ToString(), defaults["ConnectionString"].ToString(), dataSources);

            reportFile.DataBindings.Add("Text", _config, "ReportPath", false, DataSourceUpdateMode.OnPropertyChanged);
            dbConnection.DataBindings.Add("Text", _config, "ConnectionString");
            queries.DataSource = new BindingList<Config.ReportDataSource>(_config.DataSources);
        }

        private void LocalReportOnSubreportProcessing(object sender, SubreportProcessingEventArgs subreportProcessingEventArgs) {
            subreportProcessingEventArgs.DataSources.Clear();
            foreach (var dataSource in reportViewer1.LocalReport.DataSources) {
                subreportProcessingEventArgs.DataSources.Add(new ReportDataSource(dataSource.Name, dataSource.Value));
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs formClosingEventArgs) {
            var defs = Settings.Default;
            defs["ConnectionString"] = _config.ConnectionString;
            defs["ReportPath"] = _config.ReportPath;
            defs["Location"] = this.Location;
            defs["Size"] = this.Size;
            defs["Queries"] = JsonConvert.SerializeObject(_config.DataSources);
            defs.Save();
        }

        private void button1_Click(object sender, EventArgs e) {
            Debug.WriteLine(_config.ToString());
            LoadReport();
        }

        private void selectReportFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                reportFile.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            using (var db = new SqlConnection()) {
                db.ConnectionString = _config.ConnectionString;
                try {
                    db.Open();
                    MessageBox.Show("Looks good.\nMay unicorns bestow their farts upon your endeavor.", "DB: Yup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "DB: Nope.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadReport() {
            var pageSettings = reportViewer1.GetPageSettings();
            reportViewer1.LocalReport.DataSources.Clear();
            // required to reload any changes from the disk
            // unfortunately, this also clears all the settings, including event handlers
            reportViewer1.Reset(); 
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            if (pageSettings != null) reportViewer1.SetPageSettings(pageSettings);
            reportViewer1.LocalReport.SubreportProcessing += LocalReportOnSubreportProcessing;

            try {
                using (var db = new SqlConnection(_config.ConnectionString)) {
                    db.Open();
                    foreach (var query in _config.DataSources) {
                        try {
                            var datatable = new DataTable();
                            using (var adapter = new SqlDataAdapter(query.Query, db)) {
                                adapter.Fill(datatable);
                            }
                            var reportData = new ReportDataSource(query.Name, datatable);
                            reportViewer1.LocalReport.DataSources.Add(reportData);
                        } catch (Exception ex) {
                            var response = MessageBox.Show(
                                string.Format(
                                    "Encountered an error loading the dataset {0}:\n\n{1}\n\nDo you want to continue?",
                                    query.Name,
                                    ex.Message),
                                "Uh-oh",
                                MessageBoxButtons.YesNo);
                            if (response == DialogResult.No) {
                                return;
                            }
                        }
                    }
                }
                reportViewer1.LocalReport.ReportPath = _config.ReportPath;
                reportViewer1.RefreshReport();
            } catch (Exception ex) {
                MessageBox.Show(
                    "Error encountered. Hopefully you know better than me how to handle it.\n\n" + ex.Message,
                    "Uh-oh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
