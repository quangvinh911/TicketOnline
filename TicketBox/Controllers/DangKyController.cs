using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBox.Models;
namespace TicketBox.Controllers
{

    public class DangKyController : Controller
    {
        TicketBox_dbEntities db = new TicketBox_dbEntities();
        //
        // GET: /DangKy/
        [HttpGet]
        public ActionResult DangKy()
        {
            if (Session[""] != null)
                return RedirectToAction("Index", "Home");
            return View();
        }
        [HttpPost]
        public ActionResult Dang_Ky(NguoiDung DK)
        {
            if (ModelState.IsValid)
            {
                db.NguoiDung.Add(DK);
                db.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {

            return View();
        }
          [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
              string sTenTaiKhoan = f["txtTaiKhoan"].ToString();
            string sMatKhau = f.Get("txtMatKhau").ToString();
            NguoiDung dk = db.NguoiDung.SingleOrDefault(n => n.TenTaiKhoan == sTenTaiKhoan && n.MatKhau == sMatKhau);
              if(dk!=null)
              {
                  ViewBag.ThongBao = "Chúc mừng bạn đăng nhập thành công !";
                  Session["TenTaiKhoan"] = dk;
                  return View();
              }
              ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng!";
              return View();
        }
    }
}
