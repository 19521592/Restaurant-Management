using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Restaurant_Management.BUS.Report
{
    class ReportForm
    {
        public ReportTime reportTime;
        public ReportTitle reportTitle;
        public CrystalReportViewer crystalReportViewer;
        public DataTable dataTable;
        public DataTable dataTableTitle;
        public string reportPath;

        public enum Time
        {
            Today, Yesterday, SevenDaysLeft, ThisMonth, LastMonth, ThisQuarter, Optional
        }
        public ReportForm(Time kindOfTime, Panel pnlOptionalTime, CrystalReportViewer crystalReportViewer)
        {
            this.reportTime = new ReportTime(kindOfTime, pnlOptionalTime);
            this.crystalReportViewer = crystalReportViewer;
        }
        public virtual void loadInfo()
        {
            BUS.Report.ReportPreview reportPreview = new BUS.Report.ReportPreview(dataTable,
                                                                                    dataTableTitle, reportPath, crystalReportViewer);
        }
    }
}
