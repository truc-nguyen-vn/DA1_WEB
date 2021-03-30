﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_BanXeMoTo.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            ChiTietDanhGia = new HashSet<ChiTietDanhGium>();
            DatLiches = new HashSet<DatLich>();
            HoaDons = new HashSet<HoaDon>();
        }

        public string Idkh { get; set; }
        public string Idtk { get; set; }
        public string IdloaiKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public int DienThoai { get; set; }
        public string Avatar { get; set; }

        public virtual LoaiKh IdloaiKhNavigation { get; set; }
        public virtual TaiKhoan IdtkNavigation { get; set; }
        public virtual ICollection<ChiTietDanhGium> ChiTietDanhGia { get; set; }
        public virtual ICollection<DatLich> DatLiches { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
