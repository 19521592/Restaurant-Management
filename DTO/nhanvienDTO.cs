using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DTO
{
    class nhanvienDTO
    {
        //   ID VARCHAR(5) NOT NULL,
        //   HOTEN NVARCHAR(100) NOT NULL,
        //   GTINH NVARCHAR(4) NOT NULL,
        //   NGSINH SMALLDATETIME NOT NULL,
        //   DCHI NVARCHAR(100) ,
        //   CMND VARCHAR(10) NOT NULL,
        //   ACTIVE BIT,
        //   VITRI NVARCHAR(50),
        //   AVATAR NTEXT,
        private string id;
        private string hoten;
        private string gtinh;
        private DateTime ngsinh; // dâttime 
        private string dchi;
        private string cmnd;
        private bool trangthai;
        private string vitri;
        private string imgStr;

        public nhanvienDTO() { }

        public string Id { get { return id; } set { id = value; } }
        public string Hoten { get { return hoten; } set { hoten = value; } }
        public string Gtinh { get { return gtinh; } set { gtinh = value; } }
        public DateTime Ngsinh { get { return ngsinh; } set { ngsinh = value; } }
        public string Dchi { get => dchi; set { dchi = value; } }
        public string Cmnd { get => cmnd; set { cmnd = value; } }
        public bool Trangthai { get => trangthai; set { trangthai = value; } }
        public string Vitri { get => vitri; set { vitri = value; } }
        public string ImgStr
        {
            get
            {
                return imgStr;
            }
            set
            {
                imgStr = value;
            }
        }
    }
}
