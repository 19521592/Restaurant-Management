using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
using System.IO;
using System.Drawing;
using Restaurant_Management.DTO;
using System.Data;
namespace Restaurant_Management.BLL
{
    class KHACHHANG
    {
        private static KHACHHANG ins;
        public static KHACHHANG Ins
        {
            get { if (ins == null) ins = new KHACHHANG(); return ins; }
            private set { ins = value; }
        }
        private KHACHHANG() { }

        public byte[] converImgToByte(string Path)
        {
            FileStream fs;
            fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        public Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public string getMaKHnext()
        {
            string query = "SELECT MAKH FROM KHACHHANG";
            DataTable tbl = Provider.Ins.ExcuteQuery(query);
            string res = (tbl.Rows.Count + 1).ToString();
            while (res.Length < 3)
                res = "0" + res;
            res = "KH" + res;
            return res;
        }
        public bool Insert(CustomerDTO p)
        {
            string query = "INSERT INTO KHACHHANG VALUES ( @MAKH , @HOTEN , @GIOITINH , @SDT , @DIEM , @LOAIKH )";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { getMaKHnext() , p.Hoten, p.Gioitinh , p.Sdt , p.Diem , p.LoaiKH });
            return (rs > 0);
        }   
        public CustomerDTO getKH(string MaKH)
        {
            string query = "SELECT * FROM KHACHHANG WHERE MAKH = @MAKH ";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { MaKH });
            if (rs.Rows.Count == 0) return null;

            CustomerDTO tmp = new CustomerDTO();
            tmp.Makh = MaKH;
            tmp.Hoten = rs.Rows[0][1].ToString();
            tmp.Gioitinh = rs.Rows[0][2].ToString();
            tmp.Sdt = rs.Rows[0][3].ToString();
            tmp.Diem = rs.Rows[0][4].ToString();
            tmp.LoaiKH = rs.Rows[0][5].ToString();
            return tmp;
        }
        public bool Exist_Phone(string phone)
        {
            string query = "SELECT * FROM KHACHHANG WHERE SDT = @SDT ";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { phone });
            return (rs > 0);
        }
        public List<CustomerDTO> getList()
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            CustomerDTO p;
            string query = "SELECT * FROM KHACHHANG";
            DataTable rs = Provider.Ins.ExcuteQuery(query);

            for (int i = 0; i < rs.Rows.Count; i++)
            {
                p = new CustomerDTO();
                p.Makh = rs.Rows[i][0].ToString();
                p.Hoten = rs.Rows[i][1].ToString();
                p.Gioitinh = rs.Rows[i][2].ToString();
                p.Sdt = rs.Rows[i][3].ToString();
                p.Diem = rs.Rows[i][4].ToString();
                p.LoaiKH = rs.Rows[i][5].ToString();
                list.Add(p);
            }
            return list;
        }
        public DataTable getDataTable()
        {
            string query = "SELECT MAKH as 'Mã khách hàng', HOTEN as 'Họ tên', GIOITINH as 'Giới tính', SDT as 'Số điện thoại' FROM KHACHHANG";
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }
        public DataTable find(string x)
        {
            string query = "SELECT MAKH as 'Mã khách hàng', HOTEN as 'Họ tên', GIOITINH as 'Giới tính', SDT as 'Số điện thoại' FROM KHACHHANG WHERE HOTEN LIKE '%" + x + "%' OR SDT LIKE '%" + x + "%'";
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }
    }
}
