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
using Restaurant_Management.DTO;

namespace Restaurant_Management.GUI.Revenue
{
    public partial class FoodItem : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public FoodItem(FoodDTO food, int num)
        {
            InitializeComponent();
            this.lblFoodName.Text = food.Ten;
            this.lblFoodNumber.Text = "" + num;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            lblFoodNumber.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblFoodNumber.Width, lblFoodNumber.Height, 10, 10));
        }
    }
}
