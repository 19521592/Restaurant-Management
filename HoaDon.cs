using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using QuanLiMonAn.class;
//using COMEexcel = Microsoft.Office.Interop.Excel;

namespace Restaurant_Management
{
    DataTable HoaDonTiec;
    //bảng hóa đơn tiệc
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        //nhập dữ liệu lên lưới 
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaHang, b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM tblChiTietHDBan AS a, tblHang AS b WHERE a.MaHDBan = N'" + txtMaHDBan.Text + "' AND a.MaHang=b.MaHang";
            
            HoaHonTiec = Functions.GetDataToTable(sql);
            dgvHDBanHang.DataSource = HoaDonTiec;
            dgvHDBanHang.Columns[0].HeaderText = "Mã Món Ăn";
            dgvHDBanHang.Columns[1].HeaderText = "Tên Món Ăn";
            dgvHDBanHang.Columns[2].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[4].HeaderText = "Giảm giá %";
            dgvHDBanHang.Columns[5].HeaderText = "Thành tiền";
            dgvHDBanHang.Columns[0].Width = 80;
            dgvHDBanHang.Columns[1].Width = 130;
            dgvHDBanHang.Columns[2].Width = 80;
            dgvHDBanHang.Columns[3].Width = 90;
            dgvHDBanHang.Columns[4].Width = 90;
            dgvHDBanHang.Columns[5].Width = 90;
            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            btnThemHD.Enabled = true;
            btnLuuHD.Enabled = false;
            btnHuyHD.Enabled = false;
            btnInHD.Enabled = false;
            txtMaHD.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtTenMonAn.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTong.ReadOnly = true;
            txtGiamGia.Text = "0";
            txtTong.Text = "0";
            //Functions.FillCombo("SELECT MaKhach, TenKhach FROM tblKhach", txtMaKH, "MaKhachHang", "MaKhachHang");
            //txtMaKH.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNhanVien, TenNhanVien FROM tblNhanVien", cmbMaNV, "MaNhanVien", "TenKhach");
            cmbMaNV.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHang, TenHang FROM tblHang", cmbMaMonAn, "MaHang", "MaHang");
            cmbMaMonAn.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHD.Text != "")
            {
                LoadInfoHoaDon();
                btnHuyHD.Enabled = true;
                btnInHD.Enabled = true;
            }
            LoadDataGridView();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
