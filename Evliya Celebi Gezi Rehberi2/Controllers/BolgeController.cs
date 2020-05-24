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
    public class BolgeController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Bolge
        public ActionResult Index()
        {
            return View(db.Bolgeler.ToList());
        }

        // GET: Bolge/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bolge bolge = db.Bolgeler.Find(id);
            if (bolge == null)
            {
                return HttpNotFound();
            }
            return View(bolge);
        }

        // GET: Bolge/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bolge/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adi")] Bolge bolge)
        {
            if (ModelState.IsValid)
            {
                db.Bolgeler.Add(bolge);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bolge);
        }

        // GET: Bolge/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bolge bolge = db.Bolgeler.Find(id);
            if (bolge == null)
            {
                return HttpNotFound();
            }
            return View(bolge);
        }

        // POST: Bolge/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adi")] Bolge bolge)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bolge).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bolge);
        }

        // GET: Bolge/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bolge bolge = db.Bolgeler.Find(id);
            if (bolge == null)
            {
                return HttpNotFound();
            }
            return View(bolge);
        }

        // POST: Bolge/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bolge bolge = db.Bolgeler.Find(id);
            db.Bolgeler.Remove(bolge);
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
