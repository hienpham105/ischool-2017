using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISchool.Models;

namespace ISchool.Controllers
{
    public class HomeController : Controller
    {
        SCHOOLMANAGEMENTEntities db = new SCHOOLMANAGEMENTEntities();
        
        public ActionResult GetAllGiangVien()
        {
            IQueryable<GIANGVIEN> giangvien = db.GIANGVIENs;
            
            return View(giangvien.ToList());
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}