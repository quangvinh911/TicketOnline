using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using TicketBox.Models.EF;

namespace TicketBox.Models
{
    public class SuKienModel
    {
        private TicketDbContext context = null;

        public SuKienModel()
        {
            context = new TicketDbContext();
        }

        public int TaoSuKien(string tenSK, string MaLoaiSK, string DiaDiem, string ChiTietSK, DateTime? NgayToChuc, string GioBatDauSK)
        {
            object[] param =
            {
                new SqlParameter("@tensk", tenSK),
                new SqlParameter("@maloaisk", MaLoaiSK),
                new SqlParameter("@didiem", DiaDiem),
                new SqlParameter("@chitiet", ChiTietSK),
                new SqlParameter("@ngaytochuc", NgayToChuc),
                new SqlParameter("@giobatdau", GioBatDauSK)
            };
            int res = context.Database.ExecuteSqlCommand("Sp_Sukien_Insert @tensk ,@maloaisk,@didiem,@chitiet,@ngaytochuc,@giobatdau", param);
            return res;
        }
    }
}