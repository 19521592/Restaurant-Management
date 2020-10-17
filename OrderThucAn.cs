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
    public partial class OrderThucAn : Form
    {
        public OrderThucAn()
        {
            InitializeComponent();
        }


        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien staffForm = new QuanLyNhanVien();
            this.Hide();
            staffForm.FormClosing += delegate { this.Show(); };
            staffForm.ShowDialog();
        }
    }
}
