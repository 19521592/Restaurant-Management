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
    class FoodByStaff : ReportForm
    {
        
        int numberOfFoods = 0;
        double TotalMoney = 0;
        public FoodByStaff(Time kindOfTime, Panel pnlOptionalTime, CrystalReportViewer crystalReportViewer)
                : base(kindOfTime, pnlOptionalTime, crystalReportViewer)
        {
            this.reportTitle = new ReportTitle("Hàng bán theo nhân viên", reportTime);
            reportPath = Application.StartupPath.Remove(Application.StartupPath.IndexOf("\\bin\\Debug"), 10) + "\\GUI\\Report\\Template\\FoodByStaff.rpt";
        }

        public override void loadInfo()
        {
            dataTable = BLL.Report.Ins.getFoodListByStaffBetweenDate(reportTime.startTime, reportTime.endTime);
            foreach (DataRow food in dataTable.Rows)
            {
                double foodValue = Double.Parse(food[4].ToString());
                int foodCount = Int32.Parse(food[3].ToString());
                numberOfFoods += foodCount;
                TotalMoney += foodValue;
            }
            dataTable.TableName = "FoodListByStaff";
            dataTableTitle = new DataTable("FoodTitle");
            dataTableTitle.Columns.AddRange(new DataColumn[] { new DataColumn("Ngày tạo", typeof(string)),
                                                        new DataColumn("Tổng số lượng", typeof(int)),
                                                        new DataColumn("Tổng giá trị", typeof(string)),
                                                        new DataColumn("Thời gian", typeof(string)), });
            dataTableTitle.Rows.Add(new object[] { reportTitle.createdTime, numberOfFoods,
                                                TotalMoney.ToString("#,##0"), reportTitle.kindOfTime });
            base.loadInfo();
        }
    }
    
}
