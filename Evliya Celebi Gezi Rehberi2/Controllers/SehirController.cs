﻿using System;
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
    public class SehirController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Sehir
        public ActionResult Index()
        {
            var sehirler = db.Sehirler.Include(s => s.Bolge);
            return View(sehirler.ToList());
        }

        // GET: Sehir/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sehir sehir = db.Sehirler.Find(id);
            if (sehir == null)
            {
                return HttpNotFound();
            }
            return View(sehir);
        }

        // GET: Sehir/Create
        public ActionResult Create()
        {
            ViewBag.BolgeId = new SelectList(db.Bolgeler, "Id", "Adi");
            return View();
        }

        // POST: Sehir/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Adi,aciklama,Resim,Anasayfa,BolgeId")] Sehir sehir)
        {
            if (ModelState.IsValid)
            {
                db.Sehirler.Add(sehir);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BolgeId = new SelectList(db.Bolgeler, "Id", "Adi", sehir.BolgeId);
            return View(sehir);
        }

        // GET: Sehir/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sehir sehir = db.Sehirler.Find(id);
            if (sehir == null)
            {
                return HttpNotFound();
            }
            ViewBag.BolgeId = new SelectList(db.Bolgeler, "Id", "Adi", sehir.BolgeId);
            return View(sehir);
        }

        // POST: Sehir/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Adi,aciklama,Resim,Anasayfa,BolgeId")] Sehir sehir)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sehir).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BolgeId = new SelectList(db.Bolgeler, "Id", "Adi", sehir.BolgeId);
            return View(sehir);
        }

        // GET: Sehir/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sehir sehir = db.Sehirler.Find(id);
            if (sehir == null)
            {
                return HttpNotFound();
            }
            return View(sehir);
        }

        // POST: Sehir/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sehir sehir = db.Sehirler.Find(id);
            db.Sehirler.Remove(sehir);
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
