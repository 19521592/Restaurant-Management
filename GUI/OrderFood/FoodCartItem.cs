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
        bool isModify;
        public GioHang ParentForm { get; set; }
        public FoodCartItem(Food foodItem, bool isModify = true)
        {
            InitializeComponent();
            this.foodItem = new Food(foodItem);
            if (isModify == false)
            {
                this.btnMinus.Enabled = false;
                this.btnPlus.Enabled = false;
                this.txtBoxNumber.Enabled = false;
                this.btnExit.Visible = false;
            }
            this.pictureBoxFood.BackgroundImage = foodItem.Image;
            this.lblFoodName.Text = foodItem.Name;
            this.lblFoodPrice.Text = foodItem.Price.ToString("#,##0");
            this.txtBoxNumber.Text = foodItem.Number.ToString();
            this.Tag = foodItem;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtBoxNumber.Text == "")
            {
                txtBoxNumber.Text = "" + foodItem.Number;
                Form_Alert.Alert("Không để số lượng trống!", Form_Alert.enmType.Warning);
                return;
            }
            int num = Convert.ToInt32(txtBoxNumber.Text);
            if (num > 1)
            {
                txtBoxNumber.Text = "" + (--num);
                foodItem.Number = num;
                this.Tag = foodItem;
                changeCartPrice(foodItem);
            }
            else
            {
                GioHang gioHang = (this.ParentForm as GioHang);
                gioHang.removeFood(foodItem.Id);
                return;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtBoxNumber.Text == "")
            {
                txtBoxNumber.Text = "" + foodItem.Number;
                Form_Alert.Alert("Không để số lượng trống!", Form_Alert.enmType.Warning);
                return;
            }
            int num = Convert.ToInt32(txtBoxNumber.Text);
            txtBoxNumber.Text = "" + (++num);
            foodItem.Number = num;
            this.Tag = foodItem;
            changeCartPrice(foodItem);
        }
        private void changeCartPrice(Food foodItem)
        {
            if (ParentForm == null)
                return;
            GioHang gioHang = (this.ParentForm as GioHang);
            gioHang.updatePrice(foodItem);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GioHang gioHang = (this.ParentForm as GioHang);
            gioHang.removeFood(foodItem.Id);
        }

        private void checkValue(object sender, EventArgs e)
        {
            TextBox txtBoxNumber = sender as TextBox;
            int num = 0;
            if (txtBoxNumber.Text == "")
            {
                return;
            }
            if (!Int32.TryParse(txtBoxNumber.Text, out num))
            {
                Form_Alert.Alert("Chỉ được nhập số", Form_Alert.enmType.Warning);

                if (txtBoxNumber.Text.Length > 1) txtBoxNumber.Text = txtBoxNumber.Text.Remove(txtBoxNumber.Text.Length - 1, 1);
                else if (txtBoxNumber.Text.Length == 1) txtBoxNumber.Text = "1";
                return;
            }
            if (num <= 0)
            {
                Form_Alert.Alert("Số lượng phải >= 0", Form_Alert.enmType.Warning);
                txtBoxNumber.Text = "1";
                return;
            }
            updatePriceTxtBox();
        }

        private void updatePriceTxtBox()
        {
            foodItem.Number = Convert.ToInt32(txtBoxNumber.Text);
            this.Tag = foodItem;
            changeCartPrice(foodItem);
        }

    }
}
