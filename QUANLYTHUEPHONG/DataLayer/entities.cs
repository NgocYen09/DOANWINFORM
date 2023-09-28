using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public partial class Entities : DbContext
    {
        public Entities(string connect)
            : base(connect) { }

        public DbSet<tb_CongTy> congty { get; set; }
        public DbSet<tb_DatPhong> datphong { get; set; }
        public DbSet<tb_DonVi> donvi { get; set; }
        public DbSet<tb_KhachHang> khachhang { get; set; }
        public DbSet<tb_LoaiPhong> loaiphong { get; set; }
        public DbSet<tb_Phong> phong { get; set; }
        public DbSet<tb_Phong_ThietBi> phong_thietbi { get; set; }
        public DbSet<tb_SanPham> sanpham { get; set; }
        public DbSet<tb_Tang> tang { get; set; }
        public DbSet<tb_ThietBi> thietbi { get; set; }
        public DbSet<tb_Users> users { get; set; }
    }
}
