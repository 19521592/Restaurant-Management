using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.GUI.About
{
    public partial class deverloper : Form
    {
        public deverloper()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            TrangChinh f = new TrangChinh(null);
            this.Hide();
            f.ShowDialog();
        }
    }
}
