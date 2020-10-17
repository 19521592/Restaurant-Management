using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DAL;

namespace Restaurant_Management
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            loadStaff();
        }

        public void loadStaff()
        {
            dataGridViewStaffList.DataSource = Provider.Ins.ExcuteQuery("Select ID as 'Mã nhân viên', HOTEN as 'Họ và tên', GIOITINH as 'Giới tính'" +
                ", NGSINH as 'Ngày sinh', SDT as 'Số điện thoại', CMND as 'CMND/CCCD', DCHI as 'Địa chỉ' From dbo.NHANVIEN");
        }


    }
}
