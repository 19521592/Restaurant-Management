using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.BUS.Report;

namespace Restaurant_Management.GUI.Report
{
    public partial class BaoCao : Form
    {
        BUS.Report.ReportForm report;
        ReportForm.Time kindOfTime;
        string kindOfReportName;
        public BaoCao()
        {
            InitializeComponent();
            kindOfTime = ReportForm.Time.ThisMonth;
            report = new BUS.Report.RevenueDetail(kindOfTime, pnlOptionalTime, crystalReportViewer);
            kindOfReportName = report.reportTitle.title;
            loadInfo(report);
            rdBtnThisMonth.Checked = true;
            rdBtnRevenueDetail.Checked = true;        
        }
        private void attachTagForTimeRadioButton()
        {
            rdBtnOptinalTime.Tag = ReportForm.Time.Optional;
            rdBtnLastMonth.Tag = ReportForm.Time.LastMonth;
            rdBtn7daysLeft.Tag = ReportForm.Time.SevenDaysLeft;
            rdBtnThisMonth.Tag = ReportForm.Time.ThisMonth;
            rdBtnThisQuarter.Tag = ReportForm.Time.ThisQuarter;
            rdBtnToday.Tag = ReportForm.Time.Today;
            rdBtnYesterday.Tag = ReportForm.Time.Yesterday;
        }
        private void loadInfo(ReportForm report)
        {
            report.loadInfo();
            attachTagForTimeRadioButton();
        }

        private void rdBtnOptionalTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnOptinalTime.Checked == false)
            {
                pnlOptionalTime.Visible = false;
                btnOptionalTimeApply.Visible = false;
            }
            else
            {
                pnlOptionalTime.Visible = true;
                btnOptionalTimeApply.Visible = true;
            }
        }

        private void rdBtnToday_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == true)
            {
                kindOfTime = (ReportForm.Time)(sender as RadioButton).Tag;
                createReport(kindOfTime, kindOfReportName);
                loadInfo(report);
            }
        }

        private void btnOptionalTimeApply_Click(object sender, EventArgs e)
        {
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
            {
                CustomNofication.Form_Alert.Alert("Lỗi chọn thời gian!", CustomNofication.Form_Alert.enmType.Warning);
            }
            else
            {
                kindOfTime = ReportForm.Time.Optional;
                createReport(kindOfTime, report.reportTitle.title);
                loadInfo(report);
            }
        }

        private void rdBtnRevenueDetail_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton kindOfReport = (sender as RadioButton);
            if (kindOfReport.Checked == true)
            {
                this.kindOfReportName = kindOfReport.Text;
                createReport(kindOfTime, kindOfReportName);
                loadInfo(report);
            }
        }
        private void createReport(ReportForm.Time kindOfTime, string kindOfReportName)
        {
            switch (kindOfReportName)
            {
                case "Chi tiết doanh thu":
                    report = new RevenueDetail(kindOfTime, pnlOptionalTime, crystalReportViewer);
                    break;
                case "Doanh thu theo nhân viên":
                    report = new RevenueByStaff(kindOfTime, pnlOptionalTime, crystalReportViewer);
                    break;
                case "Doanh thu theo khách hàng":
                    report = new RevenueByCustomer(kindOfTime, pnlOptionalTime, crystalReportViewer);
                    break;
                case "Hàng hóa bán ra":
                    report = new FoodSelling(kindOfTime, pnlOptionalTime, crystalReportViewer);
                    break;
                case "Hàng bán theo nhân viên":
                    report = new FoodByStaff(kindOfTime, pnlOptionalTime, crystalReportViewer);
                    break;
                case "Hàng bán theo khách hàng":
                    report = new FoodByCustomer(kindOfTime, pnlOptionalTime, crystalReportViewer);
                    break;
                default:
                    break;
            }
        }
    }
}
