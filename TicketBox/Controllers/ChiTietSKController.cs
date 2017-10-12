using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBox.Models;

namespace TicketBox.Controllers
{
    public class ChiTietSKController : Controller
    {
        //
        // GET: /ChiTietSK/
        TicketOnlineEntities db = new TicketOnlineEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult ChiTietSK(string maSuKien)
        {
            SuKien sukien = db.SuKiens.SingleOrDefault(n => n.MaSK == maSuKien);
            if (sukien == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sukien);
        }
    }
}
