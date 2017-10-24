using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBox.Models.EF;

namespace TicketBox.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        TicketDbContext db = new TicketDbContext();

        public ActionResult Index()
        {
                return View();
        }
        public PartialViewResult TicketPartial ()
        {
            var listSuKien = db.SuKiens.Take(10).ToList();
            return PartialView(listSuKien);
        }
    }
}
