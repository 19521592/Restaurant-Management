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
namespace Restaurant_Management.GUI.AccountGUI
{
    public partial class ThemTaiKhoan : Form
    {
        List<string> listID;
        public ThemTaiKhoan()
        {
            InitializeComponent();
            
        }
        private void Load_Form(object sender, EventArgs e)
        {
            listID = Account.Ins.getListStaffID();
            for (int i=0; i < listID.Count; i++)
            {               
                comboBox1.Items.Add(listID[i]);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string id = comboBox1.Text;         
            staffDTO p = NhanVien.Ins.getNV(id);
            lbName.Text = p.Hoten;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text =="" || txtUserName.Text == "" || txtPass.Text == "" | txtPassConfirm.Text == "")
                    throw new Exception("Nhập chưa đủ thông tin");
                if (Account.Ins.ExistUserName(txtUserName.Text))
                    throw new Exception("Tên tài khoản đã tồn tại");
                if (txtPass.Text != txtPassConfirm.Text)
                    throw new Exception("Mật khẩu nhập không trùng khớp");
                string id = comboBox1.Text;

                bool rs = Account.Ins.Insert(id, txtUserName.Text, txtPass.Text, Account.TypeAcc.Staff);
                if (rs == true)
                {
                    Form_Alert.Alert("Thêm thành công", Form_Alert.enmType.Success);
                    this.Close();
                }
                else
                {
                    Form_Alert.Alert("Thêm thát bại", Form_Alert.enmType.Error);
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
