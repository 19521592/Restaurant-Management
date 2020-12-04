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
using Restaurant_Management.GUI.Login;
namespace Restaurant_Management.GUI.User
{
    public partial class accForm : Form
    {
        staffDTO p;
        AccountApp acc;

        CustomerDTO pK;
        CustomerAccDTO accK;
        public accForm(string id)
        {
            InitializeComponent();
            if (id.Contains("NV") == true)
            {
                p = NhanVien.Ins.getNV(id);
                acc = Account.Ins.getAccount(id);
            }
            else
            {
                pK = KHACHHANG.Ins.getKH(id);              
            }

        }

        private void AccControl_Load(object sender, EventArgs e)
        {
            if (p != null)
            {
                lbName.Text = p.Hoten;
                if (p.Gtinh == "Nam")
                {
                    rBtnSex1.Checked = true;
                    rBtnSex2.Checked = false;
                }
                else
                {
                    rBtnSex1.Checked = false;
                    rBtnSex2.Checked = true;
                }
                lbVaitro.Text = p.Vitri;
                picBox.Image = NhanVien.Ins.ByteToImg(p.ImgStr);
            }
            else
            {
                lbName.Text = pK.Hoten;
                if (pK.Gioitinh == "Nam")
                {
                    rBtnSex1.Checked = true;
                    rBtnSex2.Checked = false;
                }
                else
                {
                    rBtnSex1.Checked = false;
                    rBtnSex2.Checked = true;
                }
                lbVaitro.Text = "Khách hàng";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPass.Text == "" || txtNewPass.Text == "" | txtNewPassConfirm.Text == "")
                    throw new Exception("Không được bỏ trống");
                if (Account.Ins.GetHashPassword(txtOldPass.Text) != acc.Passwords)
                    throw new Exception("Mật khẩu cũ sai");
                if (txtNewPass.Text != txtNewPassConfirm.Text)
                    throw new Exception("Mật khẩu mới và nhập lại không giống");

                string PassChange = Account.Ins.GetHashPassword(txtNewPass.Text);
                bool rs = Account.Ins.UpdatePassWords(p.Id, PassChange);
                if (rs = true)
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công");
                    acc.Passwords = txtNewPass.Text;
                    txtNewPass.Text = "";
                    txtNewPassConfirm.Text = "";
                    txtOldPass.Text = "";
                }

                else
                    MessageBox.Show("Cập nhật mật khẩu thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button2_Click(sender, e);

        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.Close();
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }
        private void LOSTFOCUS(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
