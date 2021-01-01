using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Restaurant_Management.BUS.Report
{
    class RevenueByStaff : ReportForm
    {
        int numberOfBills = 0;
        double TotalMoney = 0;
        public RevenueByStaff(Time kindOfTime, Panel pnlOptionalTime, CrystalReportViewer crystalReportViewer)
                : base(kindOfTime, pnlOptionalTime, crystalReportViewer)
        {
            this.reportTitle = new ReportTitle("Doanh thu theo nhân viên", reportTime);
            reportPath = Application.StartupPath.Remove(Application.StartupPath.IndexOf("\\bin\\Debug"), 10) + "\\GUI\\Report\\Template\\RevenueByStaff.rpt";
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
            dataTable = BLL.Report.Ins.getStaffRevenueBetweenDate(reportTime.startTime, reportTime.endTime);
            dataTable.TableName = "RevenueByStaff";
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
