using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
namespace Restaurant_Management.BLL
{
    class NhanVien
    {
        private static NhanVien ins;
        public static NhanVien Ins
        {
            get { if (ins == null) ins = new NhanVien(); return ins; }
            private set { ins = value;    }
        }
        private NhanVien() { }

        private string getMaNVnext()
        {
            string query = "select ID from account";
            DataTable tbl = Provider.Ins.ExcuteQuery(query);
            string res = (tbl.Rows.Count + 1).ToString();
            while (res.Length < 3)
                res = "0" + res;
            res = "NV" + res;
            return res;
        }

        public DataTable Display_Datatbl()
        {
            string query = "select ID , HOTEN as 'Họ và tên' , GIOITINH as 'Giới tính' , NGSINH as 'Ngày sinh' , DCHI as 'Địa  chỉ' , SDT as 'Số điện thoại' ,  CMND as 'Chứng minh nhân dân' from Nhanvien ";
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }

        public bool Insert(string name, string sex, string birth, string Addrs, string phone, string CMND)
        {
            string query = "insert into NHANVIEN values( @ID , @name , @sex , @birth , @Addrs , @phone , @CMND );";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { getMaNVnext(), name, sex, birth, Addrs, phone, CMND });
            return (rs > 0);
        }
        public bool Delete(string ID)
        {
            string query = "delete from NHANVIEN where ID = @ID ";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { ID });
            return (rs > 0);
        }
        public bool Update(string ID, string name, string sex, string birth, string Addrs, string phone, string CMND)
        {
            string query = "UPDATE NHANVIEN SET HOTEN = @name , GIOITINH = @sex , NGSINH = @birth , DCHI = @Addrs , SDT = @phone , CMND = @CMND  WHERE ID = @ID ; ";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { name, sex, birth, Addrs, phone, CMND, ID });
            return (rs > 0);
        }
        public DataTable Exist(string foo)
        {
            string query = "SELECT * FROM Nhanvien where ID = @foo or HOTEN = @foo or GIOITINH = @foo or NGSINH = @foo or DCHI = @foo or SDT = @foo or CMND = @foo ;";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { foo, foo, foo, foo, foo, foo, foo });
            return rs;
        }
    }
}
