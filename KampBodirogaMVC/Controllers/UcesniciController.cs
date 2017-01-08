using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KampBodirogaMVC.Models;
using KampBodirogaMVC.DbContextHolder;

namespace KampBodirogaMVC.Controllers
{
    public class UcesniciController : Controller
    {
        private EFDbContext db = new EFDbContext();

        //
        // GET: /Ucesnici/

        public ActionResult Index()
        {
            return View(db.Ucesnici.ToList());
        }

        //
        // GET: /Ucesnici/Details/5

        public ActionResult Details(int id = 0)
        {
            Ucesnici ucesnici = db.Ucesnici.Find(id);
            if (ucesnici == null)
            {
                return HttpNotFound();
            }
            return View(ucesnici);
        }

        //
        // GET: /Ucesnici/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ucesnici/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ucesnici ucesnici)
        {
            if (ModelState.IsValid)
            {
                db.Ucesnici.Add(ucesnici);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ucesnici);
        }

        //
        // GET: /Ucesnici/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Ucesnici ucesnici = db.Ucesnici.Find(id);
            if (ucesnici == null)
            {
                return HttpNotFound();
            }
            return View(ucesnici);
        }

        //
        // POST: /Ucesnici/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ucesnici ucesnici)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ucesnici).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ucesnici);
        }

        //
        // GET: /Ucesnici/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Ucesnici ucesnici = db.Ucesnici.Find(id);
            if (ucesnici == null)
            {
                return HttpNotFound();
            }
            return View(ucesnici);
        }

        //
        // POST: /Ucesnici/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ucesnici ucesnici = db.Ucesnici.Find(id);
            db.Ucesnici.Remove(ucesnici);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}