using System.Collections.Generic;
using System.Linq;

namespace ReportPreviewer
{
    public class Config
    {
        public Config(string lastPath, string lastConnection, IList<ReportDataSource> dataSources) {
            DataSources = dataSources ?? new List<ReportDataSource>();
            ConnectionString = lastConnection;
            ReportPath = lastPath;
        }

        public string ReportPath { get; set; }
        public string ConnectionString { get; set; }
        public IList<ReportDataSource> DataSources { get; set; }
        public class ReportDataSource
        {
            public string Name { get; set; }
            public string Query { get; set; }
        }

        public override string ToString() {
            return string.Format(@"Report={0}
Conn={1}
Data={2}", ReportPath, ConnectionString, string.Join(", ", DataSources.Select(x => x.Name).ToArray()));
        }
    }
}
