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
            //string chuoi = "";
            //var Item = (from p in db.SuKiens select p).Take(8).ToList();
            //for (int i = 0; i < Item.Count;i++)
            //{






            //    chuoi += "<div class=\"col-lg-6 portfolio-item\">"; 
            //    chuoi +=  "<div class=\"card h-100\">";
            //    chuoi +=          "<a href=\"#\">";
            //    chuoi +=      " <img class=\"card-img-top\"  ";
            //    chuoi +=          " src =\" "+ Item[i].Image+ " \" alt=\"\">";
            //    chuoi +=         "  </a>";
            //    chuoi +=     "  <div class=\"card-body\">";
            //    chuoi += "       <h4 class=\"card-title\">  ";
            //    chuoi +=       "       <a href=\"#\">"+ Item[i].TenSK +"</a>";
            //    chuoi +=          "</h4>";
            //    chuoi += "  <li class=\"nav-item\">";
            //    chuoi += "<a class=\"nav-link\">";
            //    chuoi += "<b>Thời Gian:</b> " + String.Format("{0:MM/dd/yyyy}", Item[i].NgayToChuc) + "  <b>Giờ:</b> " + String.Format("{0:t}", Item[i].GioBatDauSK) +"    ";            
            //    chuoi +=              "  </a>";
            //    chuoi += "    </li> <li class=\"nav-item\">";
            //    chuoi += "<a class=\"nav-link\"><b> Địa Điểm: </b>"+ Item[i].DiaDiem +" </a>";
            //    chuoi +=   "         </li>";
            //    chuoi += "    <li class=\"nav-item\">";
            //    chuoi += "<a class=\"nav-link\"><b> Giá Vé: </b>" + String.Format("{0:0,0 vnđ}", Item[i].GiaVe) + " </a>";
            //    chuoi += "         </li>";
            //    chuoi +=      " </div>";
            //    chuoi +=  " </div>";
            //    chuoi +=   " </div>";
            //}
            //ViewBag.View = chuoi;
                return View();
        }
        public PartialViewResult TicketPartial ()
        {
            var listSuKien = db.SuKiens.Take(10).ToList();
            return PartialView(listSuKien);
        }
    }
}
