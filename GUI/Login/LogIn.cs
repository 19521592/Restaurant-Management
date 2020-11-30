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

namespace Restaurant_Management
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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
        }
        private void Login()
        {
            string userName = txb_UserName.Text;
            string password = Account.Ins.GetHashPassword(txbPassWord.Text);
            var loginResult = Account.Ins.Login(userName, password);
            //try
            {
                switch (loginResult)
                {
                    case null:
                        MessageBox.Show("Tài khoản / mật khẩu không đúng, xin vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OKCancel);
                        break;
                    case Account.TypeAcc.Admin: // Sẽ có thêm chỉnh sửa quyền truy cập giữa các loại tài khoản
                        OpenOrderThucAnForm(userName);
                        break;
                    case Account.TypeAcc.Staff: // Sẽ có thêm chỉnh sửa quyền truy cập giữa các loại tài khoản
                        OpenOrderThucAnForm(userName);
                        break;
                }
            }
            //catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
        private void OpenOrderThucAnForm(string userName)
        {
            AccountApp account = new AccountApp();
            account.Username = userName;
            account.Id = Account.Ins.getMaNV(userName);
            TrangChinh trangChinh = new TrangChinh(account, this);
            trangChinh.ShowDialog();
            this.Close();
        }

    }
}
