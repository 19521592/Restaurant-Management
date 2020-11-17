﻿using System;
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

        private string id;
        private string hoten;
        private string gtinh;
        private DateTime ngsinh;
        private string dchi;
        private string cmnd;
        private bool isactive;
        private string vitri;
        private Image avatar;
        private string sdt;

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
        private string getMaNVnext()
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
        public NhanVien getNV(string id)
        {
            string query = "select * from NHANVIEN where ID = @ID ";
            DataTable rs = DAL.Provider.Ins.ExcuteQuery(query, new object[] { id });
            this.id = rs.Rows[0][0].ToString();
            this.hoten = rs.Rows[0][1].ToString();
            this.gtinh = rs.Rows[0][2].ToString();
            this.ngsinh = (DateTime)rs.Rows[0][3];
            this.dchi = rs.Rows[0][4].ToString();
            this.cmnd = rs.Rows[0][5].ToString();
            this.isactive = (bool)rs.Rows[0][6];
            this.vitri = rs.Rows[0][7].ToString();
            this.avatar = ByteToImg(rs.Rows[0][8].ToString());
            this.sdt = rs.Rows[0][9].ToString();
            return this;
      }
        public bool Insert(string hoten, string gtinh, DateTime ngsinh, string dchi, string cmnd, string vitri, Image avatar, string sdt)
        {
            string query = "insert into NHANVIEN values( @ID , @HOTEN , @GTINH , @NGSINH , @DCHI , @CMND , @ACTIVE , @VITRI , @AVATAR , @SDT );";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { getMaNVnext(), hoten, gtinh, ngsinh.ToString(), dchi, cmnd, "1" , vitri, avatar , sdt});
            return (rs > 0);
        }
        public bool Update(string id, string hoten, string gtinh, DateTime ngsinh, string dchi, string cmnd, string isactive, string vitri, Image avatar, string sdt)
        {
            string query = "UPDATE NHANVIEN SET HOTEN = @hoten , GTINH = @gtinh , NGSINH = @ngsinh , DCHI = @dchi , CMND = @cmnd , @ACTIVE = @isactive , VITRI = @VITRI , AVATAR = @avatar , SDT = @sdt WHERE ID = @ID ; ";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] {id , hoten, gtinh, ngsinh.ToString() , dchi , cmnd , isactive, vitri , avatar , sdt});
            return (rs > 0);
        }
        public DataTable Exist(string foo) // chưa chĩnh sửa.
        {
            DataTable rs = new DataTable();
            return rs;
        }
        public bool Delete(string ID)
        {
            string query = "UPDATE NHANVIEN SET ACTIVE = 0 WHERE ID = @ID ";
            int rs = Provider.Ins.ExcuteNonQuery(query, new object[] { ID });
            return (rs > 0);
        }
    }
}
