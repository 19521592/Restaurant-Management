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

        public BaoCao()
        {
            InitializeComponent();
            loadInfo(ReportForm.Time.ThisMonth);
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
        private void loadInfo(ReportForm.Time kindOfTime)
        {
            BUS.Report.RevenueDetail report = new BUS.Report.RevenueDetail(kindOfTime, pnlOptionalTime, crystalReportViewer);
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
                loadInfo((ReportForm.Time)(sender as RadioButton).Tag);
        }

        private void btnOptionalTimeApply_Click(object sender, EventArgs e)
        {
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
            {
                CustomNofication.Form_Alert.Alert("Lỗi chọn thời gian!", CustomNofication.Form_Alert.enmType.Warning);
            }
            else
            {
                loadInfo(ReportForm.Time.Optional);
            }
        }
    }
}
