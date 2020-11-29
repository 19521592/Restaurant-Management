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
namespace Restaurant_Management.GUI.ManagerStaff
{
    public partial class ThemNhanVien : Form
    {
        private staffDTO staff;
        private string PathImg;
        private string ImgStrDefault;
        public ThemNhanVien()
        {
            InitializeComponent();
            PathImg = "";
            ImgStrDefault = Convert.ToBase64String(NhanVien.Ins.converImgToByte(@"..\..\images\user.png"));
            staff = new staffDTO();
            txtID.Text = NhanVien.Ins.getMaNVnext();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    PathImg = openFile.FileName;
                    pictureBox1.Image = Image.FromFile(openFile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Chọn file ảnh.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PathImg = "";
            pictureBox1.Image = NhanVien.Ins.ByteToImg(ImgStrDefault);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                    throw new Exception("Tên không được rỗng");
                if (txtDiaChi.Text == "")
                    throw new Exception("Địa chỉ không được rỗng");
                if (txtPhone.Text == "")
                    throw new Exception("Số điện thoại không được rỗng");
                if (!MONAN.Ins.check_Dongia(txtPhone.Text))
                    throw new Exception("Số điện thoại không hợp lệ");
                if (comboBox1.Text == "")
                    throw new Exception("Chức vụ không được rỗng");
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                    throw new Exception("Giới tính chưa được chọn");
                if (txtCMND.Text == "")
                    throw new Exception("Chứng minh nhân dân không được rỗng");

                staff.Hoten = txtName.Text;
                if (radioButton1.Checked) staff.Gtinh = "Nam";
                if (radioButton2.Checked) staff.Gtinh = "Nữ";
                if (radioButton3.Checked) staff.Gtinh = "Khác";
                staff.Dchi = txtDiaChi.Text;
                staff.Sdt = txtPhone.Text;
                staff.Ngsinh = dateTimePicker1.Value;
                staff.Vitri = comboBox1.Text;              
                if (PathImg == "")
                {
                    staff.ImgStr = ImgStrDefault;
                }
                else
                {
                    staff.ImgStr = Convert.ToBase64String(NhanVien.Ins.converImgToByte(PathImg));
                }

                bool rs = NhanVien.Ins.Insert(staff.Hoten, staff.Gtinh, staff.Ngsinh, staff.Dchi, staff.Cmnd, staff.Vitri, staff.ImgStr, staff.Sdt);
                if (rs == true)
                {
                    Form_Alert.Alert("Thêm bàn thành công!", Form_Alert.enmType.Success);
                }
                else
                {
                    Form_Alert.Alert("Thêm bàn thành công!", Form_Alert.enmType.Error);
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
