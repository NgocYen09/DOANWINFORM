//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_DatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_DatPhong()
        {
            this.tb_DATPHONG_CHITIET = new HashSet<tb_DATPHONG_CHITIET>();
            this.tb_DatPhong_SanPham = new HashSet<tb_DatPhong_SanPham>();
            this.tb_THANHTOAN = new HashSet<tb_THANHTOAN>();
        }
    
        public int IDDP { get; set; }
        public Nullable<int> IDKH { get; set; }
        public Nullable<int> UID { get; set; }
    
        public virtual tb_KhachHang tb_KhachHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DATPHONG_CHITIET> tb_DATPHONG_CHITIET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DatPhong_SanPham> tb_DatPhong_SanPham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_THANHTOAN> tb_THANHTOAN { get; set; }
    }
}
