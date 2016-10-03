using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebTutorial.Models;

namespace WebTutorial.Controllers
{
    public class ComplicatedModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ComplicatedModels
        public ActionResult Index()
        {
            return View(db.ComplicatedModels.ToList());
        }

        // GET: ComplicatedModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComplicatedModel complicatedModel = db.ComplicatedModels.Find(id);
            if (complicatedModel == null)
            {
                return HttpNotFound();
            }
            return View(complicatedModel);
        }

        // GET: ComplicatedModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComplicatedModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Name,PhoneNumber,str1,str2,str3,str4,str5,str6")] ComplicatedModel complicatedModel)
        {
            if (ModelState.IsValid)
            {
                db.ComplicatedModels.Add(complicatedModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(complicatedModel);
        }

        // GET: ComplicatedModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComplicatedModel complicatedModel = db.ComplicatedModels.Find(id);
            if (complicatedModel == null)
            {
                return HttpNotFound();
            }
            return View(complicatedModel);
        }

        // POST: ComplicatedModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Name,PhoneNumber,str1,str2,str3,str4,str5,str6")] ComplicatedModel complicatedModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(complicatedModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(complicatedModel);
        }

        // GET: ComplicatedModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComplicatedModel complicatedModel = db.ComplicatedModels.Find(id);
            if (complicatedModel == null)
            {
                return HttpNotFound();
            }
            return View(complicatedModel);
        }

        // POST: ComplicatedModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComplicatedModel complicatedModel = db.ComplicatedModels.Find(id);
            db.ComplicatedModels.Remove(complicatedModel);
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
