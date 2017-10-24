namespace TicketBox.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ve")]
    public partial class Ve
    {
        [Key]
        [StringLength(20)]
        public string MaVe { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDH { get; set; }

        [Required]
        [StringLength(20)]
        public string MaLoaiVe { get; set; }

        [StringLength(30)]
        public string TenVe { get; set; }

        public int? MaSK { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual LoaiVe LoaiVe { get; set; }

        public virtual SuKien SuKien { get; set; }
    }
}
