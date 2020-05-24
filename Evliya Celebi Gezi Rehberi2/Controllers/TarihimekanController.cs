using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Evliya_Celebi_Gezi_Rehberi2.Models;

namespace Evliya_Celebi_Gezi_Rehberi2.Controllers
{
    public class TarihimekanController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Tarihimekan
        public ActionResult Index()
        {
            var tarihimekanlar = db.Tarihimekanlar.Include(t => t.Sehir);
            return View(tarihimekanlar.ToList());
        }

        // GET: Tarihimekan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarihimekan tarihimekan = db.Tarihimekanlar.Find(id);
            if (tarihimekan == null)
            {
                return HttpNotFound();
            }
            return View(tarihimekan);
        }

        // GET: Tarihimekan/Create
        public ActionResult Create()
        {
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi");
            return View();
        }

        // POST: Tarihimekan/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adi,Aciklama,SehirId")] Tarihimekan tarihimekan)
        {
            if (ModelState.IsValid)
            {
                db.Tarihimekanlar.Add(tarihimekan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi", tarihimekan.SehirId);
            return View(tarihimekan);
        }

        // GET: Tarihimekan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarihimekan tarihimekan = db.Tarihimekanlar.Find(id);
            if (tarihimekan == null)
            {
                return HttpNotFound();
            }
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi", tarihimekan.SehirId);
            return View(tarihimekan);
        }

        // POST: Tarihimekan/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adi,Aciklama,SehirId")] Tarihimekan tarihimekan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tarihimekan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi", tarihimekan.SehirId);
            return View(tarihimekan);
        }

        // GET: Tarihimekan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarihimekan tarihimekan = db.Tarihimekanlar.Find(id);
            if (tarihimekan == null)
            {
                return HttpNotFound();
            }
            return View(tarihimekan);
        }

        // POST: Tarihimekan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tarihimekan tarihimekan = db.Tarihimekanlar.Find(id);
            db.Tarihimekanlar.Remove(tarihimekan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
