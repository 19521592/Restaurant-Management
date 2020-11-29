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

namespace Restaurant_Management.GUI
{
    public partial class FoodCartItem : UserControl
    {
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
        Food foodItem;
        public GioHang ParentForm { get; set; }
        public FoodCartItem(Food foodItem)
        {
            InitializeComponent();
            this.foodItem = foodItem;
            this.pictureBoxFood.BackgroundImage = foodItem.Image;
            this.lblFoodName.Text = foodItem.Name;
            this.lblFoodPrice.Text = foodItem.Price.ToString("#,##0");
            this.txtBoxNumber.Text = foodItem.Number.ToString();
            this.Tag = foodItem;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            bool canChangePrice = true;
            int num = Convert.ToInt32(txtBoxNumber.Text);
            if (num > 1)
            {
                txtBoxNumber.Text = "" + (--num);
            }
            else
            {
                canChangePrice = false;
            }
            foodItem.Number = num;
            this.Tag = foodItem;
            changeCartPrice("-", canChangePrice);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtBoxNumber.Text);
            txtBoxNumber.Text = "" + (++num);
            foodItem.Number = num;
            this.Tag = foodItem;
            changeCartPrice("+", true);
        }
        private void changeCartPrice(string updown, bool canChangePrice)
        {
            if (ParentForm == null)
                return;
            GioHang gioHang = (this.ParentForm as GioHang);

            if (updown.CompareTo("-") == 0 && canChangePrice == true)
            {
                gioHang.updatePrice(foodItem.Price, false, foodItem.Id);
            }
            else
            {
                gioHang.updatePrice(foodItem.Price, true, foodItem.Id);
            }
        }
    }
}
