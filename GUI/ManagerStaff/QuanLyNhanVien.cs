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
namespace Restaurant_Management.GUI.ManagerStaff
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            StaffItem a = new StaffItem();
            StaffItem b = new StaffItem();
            StaffItem c = new StaffItem();
            a.BackColor = Color.AliceBlue;
            b.BackColor = Color.Red;
            a.lbName.Text = "Minh";
            staffDTO stf = NhanVien.Ins.getNV("NV002");

            this.flowLayoutPanel1.Controls.Add(a);
            this.flowLayoutPanel1.Controls.Add(b);
            this.flowLayoutPanel1.Controls.Add(c);
            
        }
    }
}
