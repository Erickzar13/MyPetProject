using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExchangeRatesManager.Models;

using Microsoft.AspNet.Identity;

namespace ExchangeRatesManager.Controllers
{
    public class UserExchangeModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserExchangeModels
        [Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            return View(db.UserExchangeModels.Where(t => t.OwnerId == userId).ToList());
        }

        // GET: UserExchangeModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserExchangeModel userExchangeModel = db.UserExchangeModels.Find(id);
            if (userExchangeModel == null)
            {
                return HttpNotFound();
            }
            return View(userExchangeModel);
        }

        // GET: UserExchangeModels/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserExchangeModels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(UserExchangeModel userExchangeModel)
        {
            if (ModelState.IsValid)
            {
                userExchangeModel.OwnerId = User.Identity.GetUserId();

                db.UserExchangeModels.Add(userExchangeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userExchangeModel);
        }

        // GET: UserExchangeModels/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            UserExchangeModel userExchangeModel = db.UserExchangeModels.Find(id);


            if (userExchangeModel == null || userExchangeModel.OwnerId != User.Identity.GetUserId())
            {
                return HttpNotFound();
            }
            return View(userExchangeModel);
        }

        // POST: UserExchangeModels/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(UserExchangeModel userExchangeModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userExchangeModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userExchangeModel);
        }

        // GET: UserExchangeModels/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserExchangeModel userExchangeModel = db.UserExchangeModels.Find(id);
            if (userExchangeModel == null || userExchangeModel.OwnerId != User.Identity.GetUserId())
            {
                return HttpNotFound();
            }
            return View(userExchangeModel);
        }

        // POST: UserExchangeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            UserExchangeModel userExchangeModel = db.UserExchangeModels.Find(id);
            if (userExchangeModel.OwnerId == User.Identity.GetUserId())
            {
                db.UserExchangeModels.Remove(userExchangeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return HttpNotFound();
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
