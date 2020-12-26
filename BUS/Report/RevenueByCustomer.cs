using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Restaurant_Management.BUS.Report
{
    class RevenueByCustomer : ReportForm
    {
        int numberOfCustomers = 0;
        double TotalMoney = 0;
        public RevenueByCustomer(Time kindOfTime, Panel pnlOptionalTime, CrystalReportViewer crystalReportViewer)
                : base(kindOfTime, pnlOptionalTime, crystalReportViewer)
        {
            this.reportTitle = new ReportTitle("Doanh thu theo khách hàng", reportTime);
            reportPath = Application.StartupPath.Remove(Application.StartupPath.IndexOf("\\bin\\Debug"), 10) + "\\GUI\\Report\\Template\\RevenueByCustomer.rpt";
        }

        public override void loadInfo()
        {
            dataTable = BLL.Report.Ins.getCustomerRevenueBetweenDate(reportTime.startTime, reportTime.endTime);
            foreach (DataRow customer in dataTable.Rows)
            {
                double customerValue = Double.Parse(customer[3].ToString());
                numberOfCustomers++;
                TotalMoney += customerValue;
            }
            dataTable.TableName = "RevenueByCustomer";
            dataTableTitle = new DataTable("RevenueTitle");
            dataTableTitle.Columns.AddRange(new DataColumn[] { new DataColumn("Ngày tạo", typeof(string)),
                                                            new DataColumn("Số đơn hàng", typeof(int)),
                                                            new DataColumn("Tổng giá trị", typeof(string)),
                                                            new DataColumn("Thời gian", typeof(string)), });
            dataTableTitle.Rows.Add(new object[] { reportTitle.createdTime, numberOfCustomers,
                                                    TotalMoney.ToString("#,##0"), reportTitle.kindOfTime });
            base.loadInfo();
        }
    }
}
