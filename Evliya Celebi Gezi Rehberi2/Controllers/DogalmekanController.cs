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
    public class DogalmekanController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Dogalmekan
        public ActionResult Index()
        {
            var dogalmekanlar = db.Dogalmekanlar.Include(d => d.Sehir);
            return View(dogalmekanlar.ToList());
        }

        // GET: Dogalmekan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dogalmekan dogalmekan = db.Dogalmekanlar.Find(id);
            if (dogalmekan == null)
            {
                return HttpNotFound();
            }
            return View(dogalmekan);
        }

        // GET: Dogalmekan/Create
        public ActionResult Create()
        {
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi");
            return View();
        }

        // POST: Dogalmekan/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adi,Aciklama,SehirId")] Dogalmekan dogalmekan)
        {
            if (ModelState.IsValid)
            {
                db.Dogalmekanlar.Add(dogalmekan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi", dogalmekan.SehirId);
            return View(dogalmekan);
        }

        // GET: Dogalmekan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dogalmekan dogalmekan = db.Dogalmekanlar.Find(id);
            if (dogalmekan == null)
            {
                return HttpNotFound();
            }
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi", dogalmekan.SehirId);
            return View(dogalmekan);
        }

        // POST: Dogalmekan/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adi,Aciklama,SehirId")] Dogalmekan dogalmekan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dogalmekan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SehirId = new SelectList(db.Sehirler, "Id", "Adi", dogalmekan.SehirId);
            return View(dogalmekan);
        }

        // GET: Dogalmekan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dogalmekan dogalmekan = db.Dogalmekanlar.Find(id);
            if (dogalmekan == null)
            {
                return HttpNotFound();
            }
            return View(dogalmekan);
        }

        // POST: Dogalmekan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dogalmekan dogalmekan = db.Dogalmekanlar.Find(id);
            db.Dogalmekanlar.Remove(dogalmekan);
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
