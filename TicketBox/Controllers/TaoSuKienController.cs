using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBox.Models;
using TicketBox.Models.EF;

namespace TicketBox.Controllers
{
    public class TaoSuKienController : Controller
    {
        //
        // GET: /TaoSuKien/
        [HttpGet]
        public ActionResult TaoSuKien()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TaoSuKien(SuKien collec)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var model = new SuKienModel();
                    int res = model.TaoSuKien(collec.TenSK, collec.MaLoaiSK, collec.DiaDiem, collec.ChiTietSK, collec.NgayToChuc, collec.GioBatDauSK);
                    if (res == 0)
                        return RedirectToAction("Index");
                    else
                        ModelState.AddModelError("", "Thêm thành công");
                }

                return View(collec);
            }
            catch
            {
                return View();
            }

        }

    }
}
