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

        private void LabelEffect_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;

            if (lbl.Location.X == 20 || lbl.Location.X == 260)
            {
                lbl.Font = new Font("Microsoft Sans Serif", 9);
                lbl.Cursor = Cursors.Arrow;
                lbl.Location = new Point(lbl.Location.X, lbl.Location.Y - 12);
                foreach (Control txt in pnlInformation.Controls)
                {
                    if (txt.GetType() == typeof(TextBox) && txt.Name == "txtBox" + lbl.Name.Remove(0, 3))
                    {
                        txt.Focus();
                    }
                }
            }
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

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 6))
                {
                    ctrl.ForeColor = Color.DodgerBlue;
                    if (ctrl.Location.X != 20 || ctrl.Location.X != 260)
                    {
                        txt.Clear();
                        ctrl.Font = new Font("Microsoft Sans Serif", 9);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X , ctrl.Location.Y - 12);
                    }
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

                if (ctrl.GetType() == typeof(Label) && ctrl.Name == "lbl" + txt.Name.Remove(0, 6))
                {
                    ctrl.ForeColor = Color.Silver;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        txt.Clear();
                        ctrl.Font = new Font("Microsoft Sans Serif", 13);
                        ctrl.Cursor = Cursors.IBeam;
                        ctrl.Location = new Point(ctrl.Location.X , ctrl.Location.Y + 16);
                    }
                }


            }
        }
        private void pnlInformation_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.MONAN.Ins.getList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DTO.monanDTO p = BLL.MONAN.Ins.getMONAN(id);
            lblName.Text = p.Ten;
            lblUnitPrice.Text = p.Dongia.ToString();
            lblKind.Text = p.Loai;
            lblNote.Text = p.Ghichu;
            pictureBox1.Image = BLL.MONAN.Ins.ByteToImg(p.Hinhanh);
        }
    }
}
