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
    
    public partial class tb_Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Phong()
        {
            this.tb_DATPHONG_CHITIET = new HashSet<tb_DATPHONG_CHITIET>();
            this.tb_Phong_ThietBi = new HashSet<tb_Phong_ThietBi>();
            this.tb_THANHTOAN = new HashSet<tb_THANHTOAN>();
        }
    
        public int IDPHONG { get; set; }
        public string TENPHONG { get; set; }
        public Nullable<double> DONGIA { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public int IDTANG { get; set; }
        public int IDLOAIPHONG { get; set; }
        public Nullable<bool> DISABLED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DATPHONG_CHITIET> tb_DATPHONG_CHITIET { get; set; }
        public virtual tb_LoaiPhong tb_LoaiPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Phong_ThietBi> tb_Phong_ThietBi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_THANHTOAN> tb_THANHTOAN { get; set; }
    }
}
