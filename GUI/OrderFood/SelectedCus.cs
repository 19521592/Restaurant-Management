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
using Restaurant_Management.GUI.OrderFood;
using Restaurant_Management.DTO;
using Restaurant_Management.GUI.CustomNofication;
using Restaurant_Management.GUI.Customer;
namespace Restaurant_Management.GUI.OrderFood
{
    public partial class SelectedCus : Form
    {
        public CustomerOrderForm ParentForm { get; set; }
        public CustomerDTO customer;
        public SelectedCus(string selectedIDKhachHang = null, CustomerOrderForm orderForm = null)
        {
            InitializeComponent();
            ParentForm = orderForm;
            if (selectedIDKhachHang != null)
            {
                customer = KHACHHANG.Ins.getKH(selectedIDKhachHang);
                lbID.Text = customer.Makh;
                lbName.Text = customer.Hoten;
                lbSdt.Text = customer.Sdt;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Load_Customer()
        {
            dtgview.DataSource = KHACHHANG.Ins.getDataTable();
        }  

        private void SelectedCus_Load(object sender, EventArgs e)
        {
            Load_Customer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtgview.DataSource = KHACHHANG.Ins.find(textBox1.Text);
        }
        private void dtgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbID.Text = dtgview.SelectedRows[0].Cells[0].Value.ToString();
            lbName.Text = dtgview.SelectedRows[0].Cells[1].Value.ToString();
            lbSdt.Text = dtgview.SelectedRows[0].Cells[3].Value.ToString();
            customer = KHACHHANG.Ins.getKH(lbID.Text); // chọn khách hàng
        }

        private void btnSelectTable_Click(object sender, EventArgs e)
        {
            string idBan = ParentForm.selectedTable.tableId;
            if (customer == null)
            {
                Form_Alert.Alert("Chưa chọn khách hàng!", Form_Alert.enmType.Warning);
                return;
            }
            else
            {
                ParentForm.CustomerInTalbe.Remove(idBan);
                ParentForm.CustomerInTalbe.Add(idBan, customer);
                ParentForm.selectedCustomer = customer;
                ParentForm.btnCustomer.Text = "Khách hàng: " + customer.Hoten;
                Form_Alert.Alert("Thêm khách thành công!", Form_Alert.enmType.Success);
            }
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemKhachHang form = new ThemKhachHang();
            form.ShowDialog();
            Load_Customer();
        }
    }
}
