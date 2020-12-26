using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Restaurant_Management.BUS.Report
{
    class RevenueDetail : ReportForm
    {
        int numberOfBills = 0;
        double TotalMoney = 0;
        public RevenueDetail(Time kindOfTime, Panel pnlOptionalTime, CrystalReportViewer crystalReportViewer)
                : base(kindOfTime, pnlOptionalTime, crystalReportViewer)
        {
            this.reportTitle = new ReportTitle("Chi tiết doanh thu", reportTime);
            reportPath = Application.StartupPath.Remove(Application.StartupPath.IndexOf("\\bin\\Debug"), 10) + "\\GUI\\Report\\Template\\RevenueDetail.rpt";
        }

        public override void loadInfo()
        {
            foreach (DateTime date in reportTime._listTime)
            {
                DataTable revenueInfo = BLL.Report.Ins.getDetailRevenueByDate(date);
                if (revenueInfo.Rows.Count != 0)
                {
                    double TotalMoneyByDay = 0;
                    numberOfBills += revenueInfo.Rows.Count;
                    foreach (DataRow row in revenueInfo.Rows)
                        TotalMoneyByDay += Double.Parse(row[4].ToString());
                    TotalMoney += TotalMoneyByDay;
                }
            }
            dataTable = BLL.Report.Ins.getDetailRevenueBetweenDate(reportTime.startTime, reportTime.endTime);
            dataTable.TableName = "RevenueDetail";
            dataTableTitle = new DataTable("RevenueTitle");
            dataTableTitle.Columns.AddRange(new DataColumn[] { new DataColumn("Ngày tạo", typeof(string)), 
                                                            new DataColumn("Số đơn hàng", typeof(int)), 
                                                            new DataColumn("Tổng giá trị", typeof(string)),
                                                            new DataColumn("Thời gian", typeof(string)), });
            dataTableTitle.Rows.Add(new object[] { reportTitle.createdTime, numberOfBills, 
                                                    TotalMoney.ToString("#,##0"), reportTitle.kindOfTime });
            base.loadInfo();
        }
    }
}
