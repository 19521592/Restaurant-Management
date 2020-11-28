using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.GUI.CustomNofication;

namespace Restaurant_Management.GUI
{
    public partial class GioHang : Form
    {
        private IDictionary<string, Food> orderedFood;
        private List<string> idOrderedFood;

        double Price = 0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public GioHang(IDictionary<string, Food> orderedFood, List<string> idOrderedFood)
        {
            InitializeComponent();
            this.orderedFood = orderedFood;
            this.idOrderedFood = idOrderedFood;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            foreach (string idFoodItem in idOrderedFood)
            {
                FoodCartItem foodCartItem = new FoodCartItem(orderedFood[idFoodItem]);
                foodCartItem.ParentForm = this;
                flpnlSelectedFood.Controls.Add(foodCartItem);
                Price += orderedFood[idFoodItem].Price * orderedFood[idFoodItem].Number;
            }
            lblPrice.Text = Price.ToString("#,##0");
            lblFoodCount.Text = "(" + orderedFood.Count() + " món ăn)";
            btnSubmit.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubmit.Width, btnSubmit.Height, 20, 20));
            pnlInfo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlInfo.Width, pnlInfo.Height, 30, 30));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void updatePrice(double money, bool isPlus, string foodId)
        {
            if (isPlus == true)
            {
                Price += money;
                orderedFood[foodId].Number++;
            }
            else
            {
                Price -= money;
                orderedFood[foodId].Number--;
            }
            lblPrice.Text = Price.ToString("#,##0");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form_Alert frmAlert = new Form_Alert();
            frmAlert.showAlert("Thêm món thành công!", Form_Alert.enmType.Success);
        }
    }
}
