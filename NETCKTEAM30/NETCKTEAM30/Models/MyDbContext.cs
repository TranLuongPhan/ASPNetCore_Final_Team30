﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class MyDbContext: DbContext
    {
        public DbSet<BinhLuan> BinhLuans { get; set; }
        public DbSet<ChiTietHd> chiTietHds { get; set; }
        public DbSet<GioiTinh> GioiTinhs { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<LoaiNgDung> LoaiNgDungs { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<ThanhToan> ThanhToans { get; set; }
        public DbSet<TrangThai> TrangThais { get; set; }
        public DbSet<VanChuyen> VanChuyens { get; set; }
        public DbSet<YeuThich> Yeutthichs { get; set; }
        public MyDbContext(DbContextOptions options):base(options)
        { }
    }
}
