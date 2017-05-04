using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISchool.Models;

namespace ISchool.Controllers
{
    public class SchoolWebController : Controller
    {
        SCHOOLMANAGEMENTEntities db = new SCHOOLMANAGEMENTEntities();
        //
        //Hiển thị danh sách sinh viên
        public ActionResult DanhSachGiangVien()
        {
            return View(db.GIANGVIENs.ToList());
        }

        //Chi tiết
        public ActionResult ChiTietGiangVien(int id)
        {
            GIANGVIEN gv = db.GIANGVIENs.SingleOrDefault(n => n.MAGV == id);
            ViewBag.MAGV = gv.MAGV;
            if(gv == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(gv);
        }
        // GET: iSchoolWeb
        public ActionResult Index()
        {
            return View();
        }
    }
}