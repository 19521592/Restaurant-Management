using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Data;
using Restaurant_Management.DAL;
using Restaurant_Management.DTO;
namespace Restaurant_Management.BLL
{
    class MONAN
    {
        private static MONAN ins;
        public static MONAN Ins
        {
            get { if (ins == null) ins = new MONAN(); return ins; }
            private set { ins = value; }
        }
        private MONAN() { }
        //   ID VARCHAR(5) NOT NULL,
        //   TEN VARCHAR(50),
        //   DONGIA INT,
        //   LOAI NVARCHAR(40),
        //   HINHANH NTEXT,
        //   GHICHU NVARCHAR(100),
        //   TRANGTHAI BIT,

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
        //--
        private string getMaMONANnext()
        {
            string query = "select ID from MONAN";
            DataTable tbl = DAL.Provider.Ins.ExcuteQuery(query);
            string res = (tbl.Rows.Count + 1).ToString();
            while (res.Length < 4)
                res = "0" + res;
            res = "M" + res;
            return res;
        }
        public bool Insert(string ten, int dongia, string loai, string hinhanh, string ghichu)
        {
            string query = "INSERT INTO MONAN VALUES ( @id , @ten , @dongia , @loai , @hinhanh , @ghichu , @trangthai );";
            int rs = DAL.Provider.Ins.ExcuteNonQuery(query, new object[] { getMaMONANnext(), ten, dongia, loai, hinhanh, ghichu, '1' });
            return (rs > 0);
        }
        public bool Update(string id, string ten, int dongia, string loai, string hinhanh, string ghichu)
        {
            string query = "UPDATE MONAN SET TEN = @TEN , DONGIA = @DONGIA , LOAI = @LOAI , HINHANH = @HINHANH , GHICHU = @GHICHU  WHERE ID = @ID ";
            int rs = DAL.Provider.Ins.ExcuteNonQuery(query, new object[] { ten, dongia, loai, hinhanh, ghichu, id });
            return (rs > 0);
        }
        public bool Delete(string id)
        {
            string query = "UPDATE MONAN SET TRANGTHAI = 0 WHERE ID = @ID";
            int rs = DAL.Provider.Ins.ExcuteNonQuery(query, new object[] { id });
            return (rs > 0);
        }
        public monanDTO getMONAN(string id)
        {
            string query = "SELECT * FROM MONAN WHERE ID = @ID AND TRANGTHAI = 1";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { id });
            monanDTO p = new monanDTO();
            p.Id = rs.Rows[0][0].ToString();
            p.Ten = rs.Rows[0][1].ToString();
            p.Dongia = rs.Rows[0][2].ToString();
            p.Loai = rs.Rows[0][3].ToString();
            p.Hinhanh = rs.Rows[0][4].ToString();
            p.Ghichu = rs.Rows[0][5].ToString();
            p.Trangthai = (rs.Rows[0][6].ToString() == "True") ? true : false;
            return p;
        }
        public DataTable getList()
        {
            string query = "SELECT ID, TEN, DONGIA FROM MONAN WHERE TRANGTHAI = 1 ";
            DataTable rs = Provider.Ins.ExcuteQuery(query);
            return rs;
        }
        public DataTable getListThucAn(string loai)
        {
            string query = "SELECT ID, TEN, DONGIA FROM MONAN WHERE LOAI = @loai and TRANGTHAI = 1";
            DataTable rs = Provider.Ins.ExcuteQuery(query, new object[] { loai});
            return rs;
        }
        //
        public bool check_Dongia(string dongia)
        {
            if (dongia.Length > 13) return false;
            for (int i = 0; i < dongia.Length; i++)
            {
                if (('0' <= dongia[i]) && (dongia[i] <= '9'))
                { }    
                else
                    return false;
            }
            return true;
        }
    }
}

