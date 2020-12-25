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
namespace Restaurant_Management.GUI.Reviews
{
    public partial class Form1 : Form
    {
        string ID; // id khách hàng,
        public Form1(string id)
        {
            InitializeComponent();
            this.ID = id;
        }
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

        private void btnAppetizer_Click(object sender, EventArgs e)
        {          
            flowLayoutPanelMain.Controls.Clear();
            List<FoodDTO> list = MONAN.Ins.getList("Khai vị");
            FoodRate item;
            for (int i=0; i < list.Count; i++)
            {
                item = new FoodRate(list[i], ID);
                if (ID.Contains("NV") == true) item.btnReview.Dispose(); // Nhân viên không đc viết đánh giá
                flowLayoutPanelMain.Controls.Add(item);
            }        
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            List<FoodDTO> list = MONAN.Ins.getList("Món chính");
            FoodRate item;
            for (int i = 0; i < list.Count; i++)
            {
                item = new FoodRate(list[i], ID);
                if (ID.Contains("NV") == true) item.btnReview.Dispose(); // Nhân viên không đc viết đánh giá
                flowLayoutPanelMain.Controls.Add(item);
            }
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            List<FoodDTO> list = MONAN.Ins.getList("Món tráng miệng");
            FoodRate item;
            for (int i = 0; i < list.Count; i++)
            {
                item = new FoodRate(list[i], ID);
                if (ID.Contains("NV") == true) item.btnReview.Dispose(); // Nhân viên không đc viết đánh giá
                flowLayoutPanelMain.Controls.Add(item);
            }
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            List<FoodDTO> list = MONAN.Ins.getList("Thức uống");
            FoodRate item;
            for (int i = 0; i < list.Count; i++)
            {
                item = new FoodRate(list[i], ID);
                if (ID.Contains("NV") == true) item.btnReview.Dispose(); // Nhân viên không đc viết đánh giá
                flowLayoutPanelMain.Controls.Add(item);
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Controls.Clear();
            List<FoodDTO> list = MONAN.Ins.getList("Combo");
            FoodRate item;
            for (int i = 0; i < list.Count; i++)
            {
                item = new FoodRate(list[i], ID);
                if (ID.Contains("NV") == true) item.btnReview.Dispose(); // Nhân viên không đc viết đánh giá
                flowLayoutPanelMain.Controls.Add(item);
            }
        }
    }
}
