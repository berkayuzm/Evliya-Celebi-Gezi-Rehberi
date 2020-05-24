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
    public class EglencemekanController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Eglencemekan
        public ActionResult Index()
        {
            var eglencemekanlar = db.Eglencemekanlar.Include(e => e.Sehir);
            return View(eglencemekanlar.ToList());
        }

        // GET: Eglencemekan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eglencemekan eglencemekan = db.Eglencemekanlar.Find(id);
            if (eglencemekan == null)
            {
                return HttpNotFound();
            }
            return View(eglencemekan);
        }

        // GET: Eglencemekan/Create
        public ActionResult Create()
        {
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi");
            return View();
        }

        // POST: Eglencemekan/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adi,Aciklama,SehirId")] Eglencemekan eglencemekan)
        {
            if (ModelState.IsValid)
            {
                db.Eglencemekanlar.Add(eglencemekan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi", eglencemekan.SehirId);
            return View(eglencemekan);
        }

        // GET: Eglencemekan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eglencemekan eglencemekan = db.Eglencemekanlar.Find(id);
            if (eglencemekan == null)
            {
                return HttpNotFound();
            }
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi", eglencemekan.SehirId);
            return View(eglencemekan);
        }

        // POST: Eglencemekan/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adi,Aciklama,SehirId")] Eglencemekan eglencemekan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eglencemekan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi", eglencemekan.SehirId);
            return View(eglencemekan);
        }

        // GET: Eglencemekan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eglencemekan eglencemekan = db.Eglencemekanlar.Find(id);
            if (eglencemekan == null)
            {
                return HttpNotFound();
            }
            return View(eglencemekan);
        }

        // POST: Eglencemekan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Eglencemekan eglencemekan = db.Eglencemekanlar.Find(id);
            db.Eglencemekanlar.Remove(eglencemekan);
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
