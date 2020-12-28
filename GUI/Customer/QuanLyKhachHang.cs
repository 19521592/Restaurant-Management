using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DTO;
using Restaurant_Management.BLL;
namespace Restaurant_Management.GUI.Customer
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        public void Customers_Load()
        {
            DataPanel.Controls.Clear();
            List<CustomerDTO> list = KHACHHANG.Ins.getList();
            CusItem CI;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                CI = new CusItem();
                CI.lbID.Text = list[i].Makh;
                CI.lbName.Text = list[i].Hoten;
                CI.lbPhone.Text = list[i].Sdt;
                CI.lbSex.Text = list[i].Gioitinh;
                CI.lbKind.Text = list[i].LoaiKH;
                CI.Dock = DockStyle.Top;
                DataPanel.Controls.Add(CI);

            }
            lbCount.Text = list.Count.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ThemKhachHang form = new ThemKhachHang();
            form.ShowDialog();
            Customers_Load();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Customers_Load();
        }
    }
}
