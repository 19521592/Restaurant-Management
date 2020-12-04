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
using Restaurant_Management.GUI.CustomNofication;
namespace Restaurant_Management.GUI.Customer
{
    public partial class ThemKhachHang : Form
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            txtID.Text = KHACHHANG.Ins.getMaKHnext();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerDTO p = new CustomerDTO();

            try
            {
                if (txtName.Text == "" || txtPhone.Text == "" || txtUserName.Text == "" || txtPassWords.Text == "" || txtPassWordsConfirm.Text == "" || (radioButton1.Checked && radioButton2.Checked))
                    throw new Exception("Bạn chưa nhập đủ thông tin");
                if (MONAN.Ins.check_Dongia(txtPhone.Text) == false)
                    throw new Exception("Số điện thoại không hợp lệ");
                if (KHACHHANG.Ins.Exist_Phone(txtPhone.Text))
                    throw new Exception("Mỗi số điện thoại chỉ đăng kí 1 lần.");
                if (ACCOUNTKHACHHANG.Ins.Exists_UserName(txtUserName.Text))
                    throw new Exception("Tên tài khoản đã tồn tại.");   
                if (txtPassWords.Text != txtPassWordsConfirm.Text)
                    throw new Exception("Mật khẩu nhập lại không trùng khớp");
                            
                p.Hoten = txtName.Text;
                p.Gioitinh = (radioButton1.Checked == true) ? "Nam" : "Nữ";
                p.LoaiKH = "Bình thường";
                p.Sdt = txtPhone.Text;
                p.Diem = "0";
                bool rs = KHACHHANG.Ins.Insert(p);
                bool rs1 = ACCOUNTKHACHHANG.Ins.Insert(txtID.Text, txtUserName.Text, Account.Ins.GetHashPassword(txtPassWords.Text), p.LoaiKH);
                if (rs == true && rs1 == true)
                    Form_Alert.Alert("Đăng kí thành công.", Form_Alert.enmType.Success);
                else
                    Form_Alert.Alert("Lỗi", Form_Alert.enmType.Error);              
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }
    }
}
