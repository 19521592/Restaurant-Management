﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DTO
{
    public class FoodDTO
    {
        private string id;
        private string ten;
        private string dongia;
        private string loai;
        private string hinhanh;
        private string ghichu;
        private bool trangthai;
        public FoodDTO() { }

        public string Id { get => id; set { id = value; } }
        public string Ten { get => ten; set { ten = value; } }
        public string Dongia { get => dongia; set { dongia = value; } }
        public string Loai { get => loai; set { loai = value; } }
        public string Hinhanh { get => hinhanh; set { hinhanh = value; } }
        public string Ghichu { get => ghichu; set { ghichu = value; } }
        public bool Trangthai { get => trangthai; set { trangthai = value; } }
    }
}
