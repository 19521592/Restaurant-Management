using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class QuanLyMonAn : Form
    {
        public QuanLyMonAn()
        {
            InitializeComponent();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in pnlInformation.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 6))
                {
                    ctrl.BackColor = Color.DodgerBlue;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            foreach (Control ctrl in pnlInformation.Controls)
            {
                if (ctrl.GetType() == typeof(Panel) && ctrl.Name == "pnl" + txt.Name.Remove(0, 6))
                {
                    ctrl.BackColor = Color.Silver;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemMon themMon = new ThemMon();
            themMon.Show();
        }
    }
}
