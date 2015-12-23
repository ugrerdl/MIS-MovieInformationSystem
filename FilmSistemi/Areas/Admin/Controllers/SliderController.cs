﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FilmSistemi.Models;
using System.IO;

namespace FilmSistemi.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        private FilmSistemiEntities db = new FilmSistemiEntities();

        // GET: Admin/Slider
        public ActionResult Index()
        {
            return View(db.Simage.ToList());
        }

        // GET: Admin/Slider/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Simage simage = db.Simage.Find(id);
            if (simage == null)
            {
                return HttpNotFound();
            }
            return View(simage);
        }

        // GET: Admin/Slider/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Slider/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sid,MovieId")] Simage simage, HttpPostedFile slider)
        {
            if (ModelState.IsValid)
            {
                if (slider != null)
                {
                    // projenin bulundugu yol klasör
                    var fileName = slider.FileName;
                    var way = Path.Combine(Server.MapPath("~/Content/slider/"), fileName);
                    slider.SaveAs("");
                }
                db.Simage.Add(simage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(simage);
        }

        // GET: Admin/Slider/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Simage simage = db.Simage.Find(id);
            if (simage == null)
            {
                return HttpNotFound();
            }
            return View(simage);
        }

        // POST: Admin/Slider/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sid,İmage,MovieId")] Simage simage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(simage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(simage);
        }

        // GET: Admin/Slider/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Simage simage = db.Simage.Find(id);
            if (simage == null)
            {
                return HttpNotFound();
            }
            return View(simage);
        }

        // POST: Admin/Slider/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Simage simage = db.Simage.Find(id);
            db.Simage.Remove(simage);
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
