using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.GUI.Revenue
{
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            DataTable rs = BLL.MONAN.Ins.getList();
            for (int i=0; i < rs.Rows.Count; i++)
            {
                string id = rs.Rows[i][0].ToString();
                string ten = rs.Rows[i][0].ToString();
                string gia = rs.Rows[i][0].ToString();
                dataGridView1.Rows.Add(id, ten, gia);
            }
        }
    }
}
