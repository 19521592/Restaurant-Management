using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.BLL;
using Restaurant_Management.DTO;
using Restaurant_Management.GUI.Table;

namespace Restaurant_Management.GUI.Revenue
{
    public partial class DoanhThu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public DoanhThu()
        {
            InitializeComponent();
            cbBoxChart.Text = cbBoxChart.Items[0].ToString();
            cbBoxFood.Text = cbBoxChart.Items[0].ToString();
            //Rounded Button
            pnlAction.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlAction.Width, pnlAction.Height, 30, 30));
            pnlTopFood.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlTopFood.Width, pnlTopFood.Height, 30, 30));
            btnBill.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBill.Width, btnBill.Height, 30, 30));
            btnRevenue.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRevenue.Width, btnRevenue.Height, 30, 30));
            btnUsingTable.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnUsingTable.Width, btnUsingTable.Height, 30, 30));
        }


        private void loadRevenueChart()
        {
            string kindOfChart = cbBoxChart.Text;
            chartRevenue.Series.Clear();
            string seriesName = "Tổng tiền (VND)";
            chartRevenue.Series.Add(seriesName);

            double revenue = 0;
            int billCount = 0;
            DataTable revenueTable = HOADONBAN.Ins.getRevenueChartData(kindOfChart);
            chartRevenue.DataSource = revenueTable;
            chartRevenue.Series[seriesName].XValueMember = "DATE";
            chartRevenue.Series[seriesName].YValueMembers = "MONEY";

            foreach (DataRow bill in revenueTable.Rows)
            {
                revenue += Double.Parse(bill[1].ToString());
                billCount += Int32.Parse(bill[2].ToString());
            }
            lblRevenue.Text = "" + revenue.ToString("#,##0") + "đ";
            lblBillNumber.Text = billCount.ToString();
        }
        
        private void loadTop10Food()
        {
            flpnlTopFood.Controls.Clear();
            string kindOfTime = cbBoxFood.Text;
            DataRowCollection top10FoodData = (MONAN.Ins.getListMonBanChay(kindOfTime)).Rows;
            for (int i = 0; i < top10FoodData.Count; i++)
            {
                DataRow food = top10FoodData[i];
                FoodDTO foodItem = MONAN.Ins.getMONAN(food[0].ToString());
                FoodItem foodItemControl = new FoodItem(foodItem, Int32.Parse(food[1].ToString()));
                if (i % 2 == 0)
                {
                    foodItemControl.BackColor = Color.White;
                }
                else
                {
                    foodItemControl.BackColor = Color.LimeGreen;
                }
                flpnlTopFood.Controls.Add(foodItemControl);
            }
        }

        private void loadStaffActivities()
        {
            flpnlActivities.Controls.Clear();
            DataRowCollection top10StaffActivities = (NhanVien.Ins.getTop10NhanVienVuaThanhToan()).Rows;
            for (int i = 0; i < top10StaffActivities.Count; i++)
            {
                DataRow activity = top10StaffActivities[i];
                string staffName = activity[0].ToString();
                string tableName = activity[2].ToString();
                string totalPrice = Double.Parse(activity[3].ToString()).ToString("#,##0");
                long time = Int64.Parse(activity[1].ToString());
                RecentAction actionControl = new RecentAction(staffName, tableName, totalPrice, time);
                flpnlActivities.Controls.Add(actionControl);
            }
        }

        private void loadBtnUsingTable()
        {
            DataRowCollection listUsingTable = BANAN.Ins.getListBanAnChuaThanhToan().Rows;
            DataRowCollection listTable = BANAN.Ins.getListTable().Rows;
            lblUsingTable.Text = listUsingTable.Count.ToString();
            lblTableNumber.Text = listTable.Count.ToString();

        }

        //Events

        private void cbBoxChart_TextChanged(object sender, EventArgs e)
        {
            lblRevenueName.Text = "Doanh thu trong " + cbBoxChart.Text;
            loadRevenueChart();
        }

        private void btnUsingTable_Click(object sender, EventArgs e)
        {
            BanAn banAn = new BanAn();
            banAn.Show();
            banAn.Focus();
        }

        private void cbBoxFood_TextChanged(object sender, EventArgs e)
        {
            loadTop10Food();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            loadRevenueChart();
            loadTop10Food();
            loadStaffActivities();
            loadBtnUsingTable();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Revenue revenue = new Revenue(cbBoxChart.Text);
            revenue.ShowDialog();
            revenue.Focus();
        }
    }
}
