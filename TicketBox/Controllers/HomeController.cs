using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBox.Models;

namespace TicketBox.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        TicketOnlineEntities db = new TicketOnlineEntities();

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
