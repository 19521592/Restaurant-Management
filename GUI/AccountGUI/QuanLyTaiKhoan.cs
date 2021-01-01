using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.BLL;
using Restaurant_Management.DTO;
namespace Restaurant_Management.GUI.AccountGUI
{
    public partial class QuanLyTaiKhoan : Form
    {
        private List<string> listID;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            listID = new List<string>();
        }
        public void Account_Load()
        {
            AccItem item;
            staffDTO p;
            listID = Account.Ins.getListID();
            DataPanel.Controls.Clear();
            for (int i=0; i < listID.Count; i++)
            {
                item = new AccItem();              
                p = NhanVien.Ins.getNV(listID[i]);
                item.lbID.Text = listID[i];
                item.lbName.Text = p.Hoten;
                item.lbCHUC.Text = p.Vitri;
                item.lbTaiKhoan.Text = Account.Ins.getUserName(listID[i]);
                item.lbMatKhau.Text = "**********";
                item.Dock = DockStyle.Top;
                if (i % 2 == 0)
                {
                    item.BackColor = Color.AliceBlue;
                }
                else
                {
                    item.BackColor = Color.LightBlue;
                }
                this.DataPanel.Controls.Add(item);
                if (item.lbCHUC.Text == "Admin")
                {
                    item.pnlDelete.Visible = false;
                }
            }
            lbCount.Text = DataPanel.Controls.Count.ToString();

        }
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            Account_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan form = new ThemTaiKhoan();
            form.ShowDialog();
            Account_Load();
        }
    }
}
