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
using Restaurant_Management.GUI.Table;
using Restaurant_Management.BLL;

namespace Restaurant_Management.GUI
{
    public partial class GioHang : Form
    {
        private IDictionary<string, Food> orderedFood;
        public CustomerOrderForm ParentForm { get; set; }
        private List<string> idOrderedFood;
        private Ban selectedTable;
        private string staffId;
        private string idBanAn;

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
        public GioHang(CustomerOrderForm ParentForm, IDictionary<string, Food> orderedFood, List<string> idOrderedFood, Ban selectedTable, string staffId)
        {
            InitializeComponent();
            this.ParentForm = ParentForm;
            this.orderedFood = orderedFood;
            this.idOrderedFood = idOrderedFood;
            this.selectedTable = selectedTable;
            this.staffId = staffId;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            loadCart();
            btnSubmit.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubmit.Width, btnSubmit.Height, 20, 20));
            pnlInfo.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlInfo.Width, pnlInfo.Height, 30, 30));
        }

        private void loadCart()
        {
            flpnlSelectedFood.Controls.Clear();
            foreach (string idFoodItem in idOrderedFood)
            {
                FoodCartItem foodCartItem = new FoodCartItem(orderedFood[idFoodItem]);
                foodCartItem.ParentForm = this;
                flpnlSelectedFood.Controls.Add(foodCartItem);
                Price += orderedFood[idFoodItem].Price * orderedFood[idFoodItem].Number;
            }
            lblTableNumber.Text = selectedTable.tableName;
            lblPrice.Text = Price.ToString("#,##0");
            lblFoodCount.Text = "(" + orderedFood.Count() + " món ăn)";
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
                ++orderedFood[foodId].Number;
            }
            else
            {
                Price -= money;
                --orderedFood[foodId].Number;
            }
            lblPrice.Text = Price.ToString("#,##0");
        }

        private void btnSubmit_Click(object sender, EventArgs e) //
        {
            if (orderedFood.Count == 0)
            {
                Form_Alert.Alert("Chưa có món ăn!", Form_Alert.enmType.Warning);
            }
            else if (this.ParentForm.idBanAn != null) // Delete existing banAn and its ThucDonBan
            {
                this.idBanAn = this.ParentForm.idBanAn;
                THUCDONBAN.Ins.XoaAllMonTheoBanAn(idBanAn);
                addThucDonBan();
                this.ParentForm.selectedTable = null;

                Form_Alert.Alert("Thêm món thành công!", Form_Alert.enmType.Success);
            }
            else
            {
                addBanAn();
                addThucDonBan();
                this.ParentForm.selectedTable = null;

                Form_Alert.Alert("Đặt món thành công!", Form_Alert.enmType.Success);
                BANAN.Ins.setTableStatus(this.selectedTable.tableId, "1");
            }
            this.Close();
        }
        private void addBanAn()
        {
            this.idBanAn = BANAN.Ins.Insert(staffId, "", selectedTable.tableId);
        }
        private void addThucDonBan()
        {
            foreach (string idFood in this.idOrderedFood)
            {
                THUCDONBAN.Ins.ThemMon(this.idBanAn, idFood, this.orderedFood[idFood].Number);
            }
        }
        
        public void removeFood(string foodId)
        {
            Price = 0;
            idOrderedFood.Remove(foodId);
            orderedFood.Remove(foodId);
            loadCart();
        }
    }
}
