using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace Restaurant_Management.BUS.Report
{
    class ReportPreview
    {
        CrystalReportViewer crystalReportViewer;
        string reportPath;
        ReportDocument report = new ReportDocument();
        DataTable dataTable;
        DataTable dataTableTitle;
        public ReportPreview(DataTable dataTable, DataTable dataTableTitle,string reportPath, CrystalReportViewer crystalReportViewer)
        {
            this.reportPath = reportPath;
            this.dataTable = dataTable;
            this.dataTableTitle = dataTableTitle;
            this.crystalReportViewer = crystalReportViewer;
            loadReportPreview();
        }
        private void ConfigureCrystalReports()
        {
            report.Load(reportPath);
        }

        private void loadReport()
        {
            DataSet reportData = new DataSet();
            reportData.Tables.Add(dataTable);
            reportData.Tables.Add(dataTableTitle);
            report.SetDataSource(reportData);
            crystalReportViewer.ReportSource = report;
        }

        private void loadReportPreview()
        {
            ConfigureCrystalReports();
            loadReport();
        }
    }
}
