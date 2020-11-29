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
using Restaurant_Management.BLL;
//using COMEexcel = Microsoft.Office.Interop.Excel;

namespace Restaurant_Management
{
    
    //bảng hóa đơn tiệc
    public partial class HoaDon : Form
            {
        private DataTable dataTable = new DataTable();
        public void pullData()
        {
            string connString = "@ ";
            string query = "select *from ";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();
           
        }
        public HoaDon()
        {
            InitializeComponent();
        }
        ////nhập dữ liệu lên lưới 
        private void LoadDataGridView()
        {

            //---------------------

           

        //-------------------
        string sql;
           sql = "SELECT a.ID, b.TEN, a.SOLUONG, b.DONGIA, a.GHICHU,a.ThanhTien FROM tblChiTietHDBan AS a, tblMONAN AS b WHERE a.MaHDBan = N'" + txtMaHD.Text + "' AND a.MaMonAn=b.MaMonAn";
            
        //    //HoaHonTiec = Functions.GetDataToTable(sql);
        //   // dgvHDBanHang.DataSource = HoaDonTiec;
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
        private void HoaDon_Load(object sender, EventArgs e)
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
            txtMaMonAn.ReadOnly =true ;
            txtMaNV.ReadOnly = true;
            txtMaKH.ReadOnly = true;
            //pullData.FillCombo("SELECT MaKhach, TenKhach FROM tblKhach", txtMaKH, "MaKhachHang", "MaKhachHang");
            //txtMaKH.SelectedIndex = -1;
            //Functions.FillCombo("SELECT MaNhanVien, TenNhanVien FROM tblNhanVien", cmbMaNV, "MaNhanVien", "TenKhach");
            //cmbMaNV.SelectedIndex = -1;
            //Functions.FillCombo("SELECT MaHang, TenHang FROM tblHang", cmbMaMonAn, "MaHang", "MaHang");
            //cmbMaMonAn.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHD.Text != "")
            {
                LoadInfoHoaDon();
                btnHuyHD.Enabled = true;
                btnInHD.Enabled = true;
            }
            LoadDataGridView();
        }
        //private void LoadInfoHoaDon()
        //{
        //    string str;
        //    str = "SELECT NgayBan FROM tblHDBan WHERE MaHDBan = N'" + txtMaHDBan.Text + "'";
        //    txtNgayBan.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));
        //    str = "SELECT MaNhanVien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHDBan.Text + "'";
        //    cboMaNhanVien.Text = Functions.GetFieldValues(str);
        //    str = "SELECT MaKhach FROM tblHDBan WHERE MaHDBan = N'" + txtMaHDBan.Text + "'";
        //    cboMaKhach.Text = Functions.GetFieldValues(str);
        //    str = "SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHDBan.Text + "'";
        //    txtTongTien.Text = Functions.GetFieldValues(str);
        //    //lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongTien.Text);
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        //private void HoaDon_Load(object sender, EventArgs e)
        //{

        //}

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
