using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DTO;
using Restaurant_Management.BLL;
namespace Restaurant_Management.GUI.Reviews
{
    public partial class FoodRate : UserControl
    {
        AnhLon image = new AnhLon(@"../../images/960x480.png");
        FoodDTO food;
        string idkh;
        public FoodRate(FoodDTO food, string idkh)
        {
            InitializeComponent();
            this.food = food;
            this.idkh = idkh;
            float num = DANHGIAMONAN.Ins.getAvgStar(food.Id);
            if (num == 0)
                picRate.Image = image.AnhCat(0, 300, 1200, 270);
            else
                picRate.Image = image.AnhCat(0, 0, Convert.ToInt32(1200 * num / 5), 270);
            picFood.Image = MONAN.Ins.ByteToImg(food.Hinhanh);
            lbName.Text = food.Ten;
            lbPrice.Text = int.Parse(food.Dongia).ToString("#,##0") + "đ";
        }

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
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

        private void button2_Click(object sender, EventArgs e)
        {
            Writer form = new Writer(food, idkh);
            form.ShowDialog();
        }

        //////////////////////////////
    }
}
