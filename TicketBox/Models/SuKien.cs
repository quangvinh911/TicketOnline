//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketBox.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SuKien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SuKien()
        {
            this.Ves = new HashSet<Ve>();
        }
    
        public string MaSK { get; set; }
        public string ID { get; set; }
        public string MaLoaiSK { get; set; }
        public string TenSK { get; set; }
        public string DiaDiem { get; set; }
        public string ChiTietSK { get; set; }
        public string Image { get; set; }
        public Nullable<decimal> GiaVe { get; set; }
        public System.DateTime NgayToChuc { get; set; }
        public System.TimeSpan GioBatDauSK { get; set; }
    
        public virtual LoaiSK LoaiSK { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}