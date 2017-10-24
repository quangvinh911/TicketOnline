namespace TicketBox.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            Ves = new HashSet<Ve>();
        }

        [Key]
        [StringLength(10)]
        public string MaDonHang { get; set; }

        [Required]
        [StringLength(30)]
        public string ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDatVe { get; set; }

        [StringLength(50)]
        public string HinhThucTT { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
