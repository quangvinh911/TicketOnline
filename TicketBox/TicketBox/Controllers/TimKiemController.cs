using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBox.Areas;
using PagedList;
using PagedList.Mvc;
using TicketBox.Controllers;
using TicketBox.Areas;
namespace TicketBox.Controllers
{
    public class TimKiemController : Controller
    {
        //
        // GET: /TimKiem/
        //TicketBoxentities db = new TicketBoxentities();
        public ActionResult KqTimKiem(FormCollection f)
        {
            String TuKhoa = f["txtTimKiem"].ToString();
            //List<TicketBox> lstkqtk=db.Events.Where(n=>n)
            return View();
        }

    }
}
