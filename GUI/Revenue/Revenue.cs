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
        string recentKind;
        public Revenue(string recentKind)
        {
            InitializeComponent();
            this.recentKind = recentKind;
            this.cbBoxTime.Text = recentKind;
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            loadRevenue();
        }

        private void loadRevenue()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            DataTable rs = BLL.HOADONBAN.Ins.getHoaDonTheoThoiGian(recentKind);
            for (int i = 0; i < rs.Rows.Count; i++)
            {
                string id = rs.Rows[i][0].ToString();
                string ten = rs.Rows[i][1].ToString();
                string gia = rs.Rows[i][2].ToString();
                dataGridView1.Rows.Add(id, ten, gia);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbBoxTime_TextChanged(object sender, EventArgs e)
        {
            this.recentKind = (sender as ComboBox).Text;
            loadRevenue();
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();
            dataGridView2.Visible = false;
        }
        private void openChildFormInPanel(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDetailFood.Controls.Add(childForm);
            pnlDetailFood.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void loadDetailRevenue(string idBanAn)
        {
            DataTable rs = BLL.MONAN.Ins.getListMonTheoId(idBanAn);
            dataGridView2.DataSource = rs;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idBanAn = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dataGridView2.Visible = true;
            loadDetailRevenue(idBanAn);
        }
    }
}
