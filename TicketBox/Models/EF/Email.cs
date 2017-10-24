namespace TicketBox.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Email")]
    public partial class Email
    {
        [Key]
        public int IDEmail { get; set; }

        [Column("Email")]
        [StringLength(50)]
        public string Email1 { get; set; }
    }
}
