using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ReportPreviewer
{
    partial class PunksNotDead
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PunksNotDead));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reportFile = new System.Windows.Forms.TextBox();
            this.selectReportFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dbConnection = new System.Windows.Forms.TextBox();
            this.queries = new System.Windows.Forms.DataGridView();
            this.queryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.gogogo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.queries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "RDLC Reports|*.rdlc|All files|*.*";
            this.openFileDialog1.InitialDirectory = "c:\\dev\\";
            // 
            // reportFile
            // 
            this.reportFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportFile.Location = new System.Drawing.Point(3, 17);
            this.reportFile.Name = "reportFile";
            this.reportFile.Size = new System.Drawing.Size(689, 20);
            this.reportFile.TabIndex = 1;
            // 
            // selectReportFile
            // 
            this.selectReportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectReportFile.Location = new System.Drawing.Point(698, 16);
            this.selectReportFile.Name = "selectReportFile";
            this.selectReportFile.Size = new System.Drawing.Size(48, 20);
            this.selectReportFile.TabIndex = 2;
            this.selectReportFile.Text = "...";
            this.selectReportFile.UseVisualStyleBackColor = true;
            this.selectReportFile.Click += new System.EventHandler(this.selectReportFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Report File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&DB Connection";
            // 
            // dbConnection
            // 
            this.dbConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbConnection.Location = new System.Drawing.Point(3, 73);
            this.dbConnection.Name = "dbConnection";
            this.dbConnection.Size = new System.Drawing.Size(689, 20);
            this.dbConnection.TabIndex = 4;
            // 
            // queries
            // 
            this.queries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.queries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.queryName,
            this.queryText});
            this.queries.Location = new System.Drawing.Point(3, 135);
            this.queries.Name = "queries";
            this.queries.Size = new System.Drawing.Size(743, 779);
            this.queries.TabIndex = 7;
            // 
            // queryName
            // 
            this.queryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.queryName.DataPropertyName = "Name";
            this.queryName.HeaderText = "Name";
            this.queryName.Name = "queryName";
            this.queryName.Width = 60;
            // 
            // queryText
            // 
            this.queryText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.queryText.DataPropertyName = "Query";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.queryText.DefaultCellStyle = dataGridViewCellStyle2;
            this.queryText.HeaderText = "Query";
            this.queryText.Name = "queryText";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data &Sources";
            // 
            // gogogo
            // 
            this.gogogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gogogo.Location = new System.Drawing.Point(613, 920);
            this.gogogo.Name = "gogogo";
            this.gogogo.Size = new System.Drawing.Size(133, 31);
            this.gogogo.TabIndex = 8;
            this.gogogo.Text = "Hey! Ho! Let\'s &Go!";
            this.gogogo.UseVisualStyleBackColor = true;
            this.gogogo.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(698, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.queries);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.gogogo);
            this.splitContainer1.Panel1.Controls.Add(this.reportFile);
            this.splitContainer1.Panel1.Controls.Add(this.dbConnection);
            this.splitContainer1.Panel1.Controls.Add(this.selectReportFile);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1552, 957);
            this.splitContainer1.SplitterDistance = 749;
            this.splitContainer1.TabIndex = 10;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(799, 957);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // PunksNotDead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 957);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PunksNotDead";
            this.Text = "Report (Pre)Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.queries)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox reportFile;
        private Button selectReportFile;
        private Label label1;
        private Label label2;
        private TextBox dbConnection;
        private DataGridView queries;
        private Label label3;
        private Button gogogo;
        private Button button2;
        private SplitContainer splitContainer1;
        private ReportViewer reportViewer1;
        private DataGridViewTextBoxColumn queryName;
        private DataGridViewTextBoxColumn queryText;
    }
}

