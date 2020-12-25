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
using Restaurant_Management.GUI.CustomNofication;

namespace Restaurant_Management.GUI.Table
{
    public partial class ThanhToanBan : Form
    {
        private IDictionary<string, Food> orderedFood;
        private List<string> idOrderedFood;
        private Ban selectedTable;
      //  private string staffId;
        private string idBanAn;
        public CustomerOrderForm ParentForm { get; set; }

        double Price = 0;
        public ThanhToanBan(Ban selectedTable, CustomerOrderForm ParentForm = null)
        {
            InitializeComponent();
            this.selectedTable = selectedTable;
            this.ParentForm = ParentForm;
            //this.ParentForm = ParentForm;
            this.idBanAn = BANAN.Ins.getBanAnChuaThanhToan(selectedTable.tableId).Rows[0][0].ToString();
            lblStaff.Text = BANAN.Ins.getBanAnChuaThanhToan(selectedTable.tableId).Rows[0][1].ToString();
            idOrderedFood = new List<string>();
            orderedFood = new Dictionary<string, Food>();
        }
        private void loadMenu()
        {
            flpnlFood.Controls.Clear();
            foreach (string idFoodItem in idOrderedFood)
            {
                FoodCartItem foodCartItem = new FoodCartItem(orderedFood[idFoodItem], false);
                flpnlFood.Controls.Add(foodCartItem);
                Price += orderedFood[idFoodItem].Price * orderedFood[idFoodItem].Number;
            }
            lblTableName.Text = selectedTable.tableName;
            lblPrice.Text = Price.ToString("#,##0");
        }

        //MONAN.ID, MONAN.TEN, MONAN.DONGIA, THUCDONBAN.SOLUONG, MONAN.HINHANH
        private void getListFood()
        {
            var listFood = MONAN.Ins.getListMonThanhToan(idBanAn).Rows;
            foreach (DataRow food in listFood)
            {
                Food foodItem = new Food();
                foodItem.Id = food[0].ToString();
                foodItem.Name = food[1].ToString();
                foodItem.Price = Convert.ToDouble(food[2]);
                foodItem.Number = Convert.ToInt32(food[3]);
                foodItem.Image = MONAN.Ins.ByteToImg(food[4].ToString());

                idOrderedFood.Add(foodItem.Id);
                orderedFood.Add(foodItem.Id, foodItem);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            addHoaDonBan();
            Form_Alert.Alert("Thanh toán thành công!", Form_Alert.enmType.Success);
            BANAN.Ins.setTableStatus(this.selectedTable.tableId, "0");
            if (this.ParentForm != null)
            {
                this.ParentForm.selectedTable = null;
            }
            this.Close();
        }
        private void addHoaDonBan()
        {
            HOADONBAN.Ins.Create(idBanAn, 0);
        }

        private void ThanhToanBan_Load(object sender, EventArgs e)
        {
            getListFood();
            loadMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
