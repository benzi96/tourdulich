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
    
    public partial class tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tour()
        {
            this.chitietdiemthamquan = new HashSet<chitietdiemthamquan>();
            this.doandulich = new HashSet<doandulich>();
            this.giatour = new HashSet<giatour>();
        }
    
        public int id { get; set; }
        public string tentour { get; set; }
        public string dacdiem { get; set; }
        public Nullable<int> idlh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietdiemthamquan> chitietdiemthamquan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doandulich> doandulich { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<giatour> giatour { get; set; }
        public virtual loaihinhdulich loaihinhdulich { get; set; }
    }
}