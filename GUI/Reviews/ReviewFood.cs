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
    public partial class ReviewFood : Form
    {
        AnhLon image = new AnhLon(@"../../images/960x480.png");
        FoodDTO food;
        public ReviewFood(FoodDTO food)
        {
            InitializeComponent();
            this.food = food;
        }

        private void ReviewFood_Load(object sender, EventArgs e)
        {
            List<DanhGiaDTO> list = DANHGIAMONAN.Ins.getList(food.Id);
            CusRate item;
            CustomerDTO human;
            float numberStar = 0;
            for (int i = 0; i < list.Count; i++)
            {
                human = KHACHHANG.Ins.getKH(list[i].Idkhachhang);
                numberStar = int.Parse(list[i].Sao);
                item = new CusRate();
                item.lbName.Text = human.Hoten;
                item.picRate.Image = image.AnhCat(0, 0, Convert.ToInt32(1200 * numberStar / 5), 270);
                item.richTextBox1.Text = list[i].Noidung;
                item.Dock = DockStyle.Top;
                pnlData.Controls.Add(item);
            }

            lbName.Text = food.Ten;
            float numberAVGStar = DANHGIAMONAN.Ins.getAvgStar(food.Id);
            
            lbCount.Text = list.Count.ToString();
            if (numberAVGStar == 0)
                picRate.Image = image.AnhCat(0 , 300 , 1200 , 270);
            else
                picRate.Image = image.AnhCat(0, 0, Convert.ToInt32(1200 * numberAVGStar / 5), 270);
        }
        //////////////////////////////////
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
