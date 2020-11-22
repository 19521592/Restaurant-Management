using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DTO
{
    class monanDTO
    {
        //   ID VARCHAR(5) NOT NULL,
        //   TEN VARCHAR(50),
        //   DONGIA INT,
        //   LOAI NVARCHAR(40),
        //   HINHANH NTEXT,
        //   GHICHU NVARCHAR(100),
        //   TRANGTHAI BIT,
        private string id;
        private string ten;
        private int dongia;
        private string loai;
        private string hinhanh;
        private string ghichu;
        private bool trangthai;
        public monanDTO() { }

        public string Id { get => id; set { id = value; } }
        public string Ten { get => ten; set { ten = value; } }
        public int Dongia { get => dongia; set { dongia = value; } }
        public string Loai { get => loai; set { loai = value; } }
        public string Hinhanh { get => hinhanh; set { hinhanh = value; } }
        public string Ghichu { get => ghichu; set { ghichu = value; } }
        public bool Trangthai { get => trangthai; set { trangthai = value; } }
    }
}
