using KiemTra_NguyenDinhKhai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra_NguyenDinhKhai.Controllers
{
    public class DangKiController : Controller
    {
        // GET: DangKi
        SinhVienDataContext data = new SinhVienDataContext();

        public ActionResult DangKy()
        {
            var all_Dangky = from HP in data.DangKies select HP;
            return View(all_Dangky);
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var MaSinhVien = collection["masv"];
            SinhVien sv = data.SinhViens.SingleOrDefault(n => n.MaSV == MaSinhVien);
            if (sv.MaSV != MaSinhVien)
            {
                ViewBag.ThongBao = "MSSV sai";
            }
            else
            {
                ViewBag.ThongBao = "Thanh Cong";
                Session["TaiKhoan"] = sv;

            }
            return RedirectToAction("Index", "Home");
        }
    }
}