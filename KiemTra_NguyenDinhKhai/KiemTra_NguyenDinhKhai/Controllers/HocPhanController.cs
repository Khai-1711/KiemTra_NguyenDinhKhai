using KiemTra_NguyenDinhKhai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra_NguyenDinhKhai.Controllers
{
    public class HocPhanController : Controller
    {
        // GET: HocPhan
        SinhVienDataContext data = new SinhVienDataContext();
        public ActionResult ListHocPhan()
        {
            var all_sinhvien = from tt in data.HocPhans select tt;
            return View(all_sinhvien);
        }
    }
}