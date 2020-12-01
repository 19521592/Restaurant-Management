using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.GUI.User
{
    public partial class Form1 : Form
    {
        AccControl p;
        public Form1()
        {
            InitializeComponent();
            p = new AccControl("NV005");
            this.Controls.Add(p);
        }

     

        private void panel1_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
       
        }
    }
}
