namespace TicketBox.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SuKien")]
    public partial class SuKien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SuKien()
        {
            Ves = new HashSet<Ve>();
        }

        [Key]
        [DisplayName ("Mã sự kiện")]
        public int MaSK { get; set; }

        [Required]
        [StringLength(30)]
        public string ID { get; set; }

        [StringLength(20)]
        [DisplayName("Mã loại sự kiện")]
        public string MaLoaiSK { get; set; }

        [StringLength(50)]
        [DisplayName("Tên sự kiện")]
        public string TenSK { get; set; }

        [StringLength(50)]
        [DisplayName("Địa điểm")]
        public string DiaDiem { get; set; }

        [StringLength(500)]
        [DisplayName("Chi tiết sự kiện")]
        public string ChiTietSK { get; set; }

        [StringLength(50)]
        [DisplayName("Hình")]
        public string Image { get; set; }

        [Column(TypeName = "money")]
        [DisplayName("Giá")]
        public decimal? GiaVe { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Ngày tổ chức")]
        public DateTime NgayToChuc { get; set; }

        [StringLength(10)]
        [DisplayName("Giờ bắt đầu")]
        public string GioBatDauSK { get; set; }

        public virtual LoaiSK LoaiSK { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
