using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Management.DAL;
using System.IO;
using System.Drawing;
using Restaurant_Management.DTO;
namespace Restaurant_Management.BLL
{
    class NhanVien
    {
        private static NhanVien ins;
        public static NhanVien Ins
        {
            get { if (ins == null) ins = new NhanVien(); return ins; }
            private set { ins = value; }
        }
        private NhanVien() { }

        //   ID VARCHAR(5) NOT NULL,
        //   HOTEN NVARCHAR(100) NOT NULL,
        //   GTINH NVARCHAR(4) NOT NULL,
        //   NGSINH SMALLDATETIME NOT NULL,
        //   DCHI NVARCHAR(100) ,
        //   CMND VARCHAR(10) NOT NULL,
        //   ACTIVE BIT,
        //   VITRI NVARCHAR(50),
        //   AVATAR NTEXT,
        //   CONSTRAINT PK_NHANVIEN PRIMARY KEY(ID)

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
        public string getMaNVnext()
        {
            string query = "select ID from nhanvien";
            DataTable tbl = Provider.Ins.ExcuteQuery(query);
            string res = (tbl.Rows.Count + 1).ToString();
            while (res.Length < 3)
                res = "0" + res;
            res = "NV" + res;
            return res;
        }

        public DataTable getList()
        {
            string query = "select ID , HOTEN as 'Họ và tên' , GTINH as 'Giới tính' , NGSINH as 'Ngày sinh' from NHANVIEN ";
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }
        public staffDTO getNV(string id)
        {
            string query = "select * from NHANVIEN where ID = @ID ";
            DataTable rs = DAL.Provider.Ins.ExcuteQuery(query, new object[] { id });
            if (rs.Rows.Count == 0) { return null; }
            staffDTO res = new staffDTO();
            res.Id = rs.Rows[0][0].ToString();
            res.Hoten = rs.Rows[0][1].ToString();
            res.Gtinh = rs.Rows[0][2].ToString();
            res.Ngsinh = (DateTime)rs.Rows[0][3];
            res.Dchi = rs.Rows[0][4].ToString();
            res.Cmnd = rs.Rows[0][5].ToString();
            res.Trangthai = (bool)rs.Rows[0][6];
            res.Vitri = rs.Rows[0][7].ToString();
            res.ImgStr = rs.Rows[0][8].ToString();
            res.Sdt = rs.Rows[0][9].ToString();
            return res;
      }
        public bool Insert(string hoten, string gtinh, DateTime ngsinh, string dchi, string cmnd ,string vitri, string avatar, string sdt)
        {
            string query = "insert into NHANVIEN values( @ID , @HOTEN , @GTINH , @NGSINH , @DCHI , @CMND , @ACTIVE , @VITRI , @AVATAR , @SDT );";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { getMaNVnext(), hoten, gtinh, ngsinh.ToString(), dchi, cmnd, "1" , vitri, avatar , sdt});
            return (rs > 0);
        }
        public bool Update(string id, string hoten, string gtinh, DateTime ngsinh, string dchi, string cmnd, string isactive, string vitri, string avatar, string sdt)
        {
            string query = "UPDATE NHANVIEN SET HOTEN = @hoten , GTINH = @gtinh , NGSINH = @ngsinh , DCHI = @dchi , CMND = @cmnd , ACTIVE = @isactive , VITRI = @VITRI , AVATAR = @avatar , SDT = @sdt WHERE ID = @ID ; ";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { hoten, gtinh, ngsinh.ToString() , dchi , cmnd , isactive, vitri , avatar , sdt, id});
            return (rs > 0);
        }
        public bool Delete(string ID)
        {
            string query = "UPDATE NHANVIEN SET ACTIVE = 0 WHERE ID = @ID ";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { ID });
            return (rs > 0);
        }
        public List<staffDTO> getListDTO()
        {
            string query = "SELECT * FROM NHANVIEN WHERE ACTIVE = 1";
            DataTable rs = Provider.Ins.ExcuteQuery(query);

            List<staffDTO> ls = new List<staffDTO>();
            staffDTO p;
            for (int i =0; i < rs.Rows.Count; i++)
            {
                p = new staffDTO();
                p.Id = rs.Rows[i][0].ToString();
                p.Hoten = rs.Rows[i][1].ToString();
                p.Gtinh = rs.Rows[i][2].ToString();
                p.Ngsinh = (DateTime)rs.Rows[i][3];
                p.Dchi = rs.Rows[i][4].ToString();
                p.Cmnd = rs.Rows[i][5].ToString();
                p.Trangthai = (bool)rs.Rows[i][6];
                p.Vitri = rs.Rows[i][7].ToString();
                p.ImgStr = rs.Rows[i][8].ToString();
                p.Sdt = rs.Rows[i][9].ToString();
                ls.Add(p);               
            }
            return ls;
        }
        public DataTable getTop10NhanVienVuaThanhToan()
        {
            string query = " SELECT TOP 10 NV.HOTEN , DATEDIFF( Minute , HD.NGAYTHANHTOAN , GETDATE() ) AS 'DATE' , B.TEN , HD.TONGTIEN FROM NHANVIEN NV , BANAN BA , BAN B , HOADONBAN HD WHERE NV.ID = BA.IDNHANVIEN AND BA.IDBAN = B.ID AND BA.ID = HD.ID ORDER BY DATE ";
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }
    }
}
