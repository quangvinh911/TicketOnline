namespace TicketBox.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TicketDbContext : DbContext
    {
        public TicketDbContext()
            : base("name=TicketDbContext")
        {
        }

        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<LoaiSK> LoaiSKs { get; set; }
        public virtual DbSet<LoaiVe> LoaiVes { get; set; }
        public virtual DbSet<SuKien> SuKiens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDonHang)
                .IsFixedLength();

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.Ves)
                .WithRequired(e => e.DonHang)
                .HasForeignKey(e => e.MaDH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiVe>()
                .HasMany(e => e.Ves)
                .WithRequired(e => e.LoaiVe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SuKien>()
                .Property(e => e.GiaVe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SuKien>()
                .Property(e => e.GioBatDauSK)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.SuKiens)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaVe)
                .IsUnicode(false);

            modelBuilder.Entity<Ve>()
                .Property(e => e.MaDH)
                .IsFixedLength();
        }
    }
}
