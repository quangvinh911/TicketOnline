using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBox.Models.EF;
namespace TicketBox.Controllers
{

    public class DangKyController : Controller
    {
        TicketDbContext db = new TicketDbContext();
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
        public ActionResult Dang_Ky(TaiKhoan DK)
        {
            if (ModelState.IsValid)
            {
                db.TaiKhoans.Add(DK);
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
            TaiKhoan dk = db.TaiKhoans.SingleOrDefault(n => n.TenTK == sTenTaiKhoan && n.MatKhau == sMatKhau);
            if (dk != null)
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
