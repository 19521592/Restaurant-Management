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
namespace Restaurant_Management.GUI.Reviews
{
    public partial class Writer : Form
    {
        AnhLon image = new AnhLon(@"../../images/960x480.png");
        private FoodDTO food;
        private string idkh;
        public Writer(FoodDTO food,string Idkh)
        {
            InitializeComponent();
            this.food = food;
            this.idkh = Idkh;
            lbName.Text = food.Ten;
            pictureBox1.Image = image.AnhCat(0, 0, 240, 270);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////
        /// </summary>
        public class AnhLon
        {
            Image anh;
            public AnhLon(string duongDanAnh)
            {
                anh = Image.FromFile(duongDanAnh);
            }
            public Bitmap AnhCat(int X, int Y, int Width, int Height)
            {
                Bitmap bm = new Bitmap(Width, Height);
                Graphics g = Graphics.FromImage(bm);
                g.DrawImage(anh, -X, -Y);
                return bm;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReviewFood form = new ReviewFood(food);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                    throw new Exception("Thông tin không được bỏ trống.");

                DanhGiaDTO p = new DanhGiaDTO();
                p.Idkhachhang = idkh;
                p.Idmonan = food.Id;
                p.Sao = comboBox1.Text;
                p.Noidung = richTextBox1.Text;
                DANHGIAMONAN.Ins.Insert(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
