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
using Restaurant_Management.GUI.ManageFood;
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

        private void Form1_Load(object sender, EventArgs e) 
        {
            dataGridView1.DataSource = BLL.MONAN.Ins.getList();
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FoodDTO p = BLL.MONAN.Ins.getMONAN(id);
            txtBoxName.Text = p.Ten;
            txtBoxUnitPrice.Text = p.Dongia.ToString();
            txtBoxKind.Text = p.Loai;
            txtBoxNote.Text = p.Ghichu;
            pictureBox1.Image = BLL.MONAN.Ins.ByteToImg(p.Hinhanh);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemMon themMon = new ThemMon();
            themMon.ShowDialog();
            dataGridView1.DataSource = BLL.MONAN.Ins.getList();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn món.");
                return;
            }
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            BLL.MONAN.Ins.Delete(id);
            dataGridView1.DataSource = BLL.MONAN.Ins.getList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FoodDTO p = BLL.MONAN.Ins.getMONAN(id);
            txtBoxName.Text = p.Ten;
            txtBoxUnitPrice.Text = p.Dongia.ToString();
            txtBoxKind.Text = p.Loai;
            txtBoxNote.Text = p.Ghichu;
            pictureBox1.Image = BLL.MONAN.Ins.ByteToImg(p.Hinhanh);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SuaMon suaMon = new SuaMon(id);
            suaMon.ShowDialog();
            dataGridView1.DataSource = BLL.MONAN.Ins.getList();
        }
    }
}
