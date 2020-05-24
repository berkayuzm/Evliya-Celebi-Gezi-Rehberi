using Evliya_Celebi_Gezi_Rehberi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Evliya_Celebi_Gezi_Rehberi2.Controllers
{
    public class HomeController : Controller
    {
       private DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Sehirler.Where(i => i.Anasayfa == true).ToList();
            return View(data);
        }

        public ActionResult Sehirler()
        {
            var data = db.Sehirler.ToList();
            return View(data);
        }
        public ActionResult Istanbul()
        {
            return View();
        }


        public ActionResult SehirDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sehir sehir = db.Sehirler.Find(id);
            var dogalmekan = db.Dogalmekanlar.Where(i => i.SehirId == id).ToList();
            ViewBag.dogalmekan = dogalmekan;

            var tarihimekan=db.Tarihimekanlar.Where(i => i.SehirId == id).ToList();
            ViewBag.tarihimekan = tarihimekan;

            var eglencemekan=db.Eglencemekanlar.Where(i => i.SehirId == id).ToList();
            ViewBag.eglencemekan = eglencemekan;
            return View(sehir);
         

        }
    }
}