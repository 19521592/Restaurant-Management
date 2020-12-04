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
namespace Restaurant_Management
{
    public partial class ThemMon : Form
    {
        private FoodDTO food;
        string PathImg;
        string ImgStrDefault;
        public ThemMon()
        {
            InitializeComponent();
            PathImg = "";
            ImgStrDefault = Convert.ToBase64String(MONAN.Ins.converImgToByte(@"..\..\images\food.png"));
            food = new FoodDTO();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelEffect_Click(object sender, EventArgs e)
        {
            var lbl = sender as Label;

            if (lbl.Location.X == 41)
            {
                lbl.Font = new Font("Microsoft Sans Serif", 9);
                lbl.Cursor = Cursors.Arrow;
                lbl.Location = new Point(lbl.Location.X, lbl.Location.Y - 15);
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
                    if (ctrl.Location.X != 41)
                    {
                        txt.Clear();
                        ctrl.Font = new Font("Microsoft Sans Serif", 9);
                        ctrl.Cursor = Cursors.Arrow;
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - 15);
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
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + 16);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxName.Text == "")
                    throw new Exception("Trường 'Tên' không được trống");
                if (txtBoxUnitPrice.Text == "")
                    throw new Exception("Trường 'Đơn giá' không được trống");
                if (!MONAN.Ins.check_Dongia(txtBoxUnitPrice.Text))
                    throw new Exception("Trường 'Đơn giá' không hợp lệ");
                if (txtBoxKind.Text == "")
                    throw new Exception("Trường 'loại' không được trống");
                food.Ten = txtBoxName.Text;
                food.Dongia = txtBoxUnitPrice.Text;
                food.Ghichu = txtBoxNote.Text;
                food.Loai = txtBoxKind.Text;
                if (PathImg == "")
                {
                    food.Hinhanh = ImgStrDefault;
                }
                else
                {
                    food.Hinhanh = Convert.ToBase64String(MONAN.Ins.converImgToByte(PathImg));
                }

                bool rs = MONAN.Ins.Insert(food.Ten, int.Parse(food.Dongia), food.Loai, food.Hinhanh, food.Ghichu);
                if (rs == true)
                {
                    MessageBox.Show("Thêm món thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm món thất bại");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    PathImg = openFile.FileName;
                    pictureBox1.Image = Image.FromFile(openFile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Chọn file ảnh.");
            }
        }
    }
}
