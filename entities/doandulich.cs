//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class doandulich
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doandulich()
        {
            this.chitietdoandulich = new HashSet<chitietdoandulich>();
            this.phancong = new HashSet<phancong>();
            this.phieuthanhtoan = new HashSet<phieuthanhtoan>();
        }
    
        public int id { get; set; }
        public Nullable<int> idtour { get; set; }
        public Nullable<System.DateTime> ngaykhoihanh { get; set; }
        public Nullable<System.DateTime> ngayketthuc { get; set; }
        public string chuongtrinhthamquan { get; set; }
        public string tendoan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietdoandulich> chitietdoandulich { get; set; }
        public virtual tour tour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phancong> phancong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phieuthanhtoan> phieuthanhtoan { get; set; }
    }
}