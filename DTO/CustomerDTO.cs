using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DTO
{
    class CustomerDTO
    {
        public CustomerDTO() 
        {
            Diem = "0";
        }
        public string Makh { get; set; }
        public string Hoten { get; set; }
        public string Gioitinh { get; set; }
        public string Sdt { get; set; }
        public string Diem { get; set; }
        public string LoaiKH { get; set; }
    }
}
