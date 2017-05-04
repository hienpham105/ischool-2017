using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISchool.Models;

namespace ISchool.Controllers
{
    public class SinhvienController : Controller
    {
        // GET: iSinhvien
        SCHOOLMANAGEMENTEntities db = new SCHOOLMANAGEMENTEntities();
        //
        //Hiển thị danh sách sinh viên
        public ActionResult DanhSachSinhVien()
        {
            return View(db.SINHVIENs.ToList());
        }

        //Chi tiết
        public ActionResult ChiTietSinhVien(int id)
        {
            SINHVIEN sv = db.SINHVIENs.SingleOrDefault(n => n.MSSV == id);
            ViewBag.MSSV = sv.MSSV;
            if (sv == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sv);
        }
    }
}