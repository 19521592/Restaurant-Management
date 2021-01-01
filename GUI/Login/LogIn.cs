using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Restaurant_Management.BLL;
using Restaurant_Management.GUI.Login;
using Restaurant_Management.GUI.Customer;
namespace Restaurant_Management
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();          
        }


        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txbPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Login();
            }
            else
            {

            }
        }
        private void Login()
        {
            SetTime.setTimeDMY();
            
            string userName = txb_UserName.Text;
            string password = Account.Ins.GetHashPassword(txbPassWord.Text);
            var loginResult = Account.Ins.Login(userName, password);
            //try
            {
                switch (loginResult)
                {                
                    case Account.TypeAcc.Admin: // Sẽ có thêm chỉnh sửa quyền truy cập giữa các loại tài khoản
                        OpenOrderThucAnForm(userName, true);
                        break;
                    case Account.TypeAcc.Staff: // Sẽ có thêm chỉnh sửa quyền truy cập giữa các loại tài khoản
                        OpenOrderThucAnForm(userName, false);
                        break;
                    default:
                        if (ACCOUNTKHACHHANG.Ins.Login(userName, password))
                        {
                            OpenOrderThucAnForm(userName, false, ACCOUNTKHACHHANG.Ins.getID(userName));
                        }
                        else
                        { 
                        MessageBox.Show("Tài khoản / mật khẩu không đúng, xin vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OKCancel);
                        }
                        break;
                }
            }
            //catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
        private void OpenOrderThucAnForm(string userName, bool isAdmin, string ID = null)
        {
            AccountApp account = new AccountApp();
            account.Username = userName;

            if (ID == null)
            {
                account.Id = Account.Ins.getMaNV(userName);
            }
            else
            {
                account.Id = ID;
            }
            
            TrangChinh trangChinh = new TrangChinh(account, this);
            if (isAdmin == true)
            {
                trangChinh.loadStaff();
            }
            else if (ID == null)
            {
                trangChinh.loadAdmin();
            }
            else
            {
                trangChinh.loadCustomer();
            }
            this.Hide();
            trangChinh.ShowDialog();
            //this.Hide();
            //this.Close();
        }

        private void txb_UserName_Click(object sender, EventArgs e)
        {
            txb_UserName.Text = string.Empty;
        }

        private void txbPassWord_Click(object sender, EventArgs e)
        {
            txbPassWord.Text = string.Empty;
        }

        private void txb_UserName_Leave(object sender, EventArgs e)
        {
            txbPassWord.Text = string.Empty;
            txbPassWord.UseSystemPasswordChar = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ThemKhachHang form = new ThemKhachHang();
            form.ShowDialog();
        }
    }
}
