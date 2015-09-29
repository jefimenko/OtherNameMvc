using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class ThingsController : Controller
    {
        private ThingDbContext db = new ThingDbContext();

        //
        // GET: /Things/

        public ActionResult Index()
        {
            return View(db.Things.ToList());
        }

        //
        // GET: /Things/Details/5

        public ActionResult Details(int id = 0)
        {
            DataThing datathing = db.Things.Find(id);
            if (datathing == null)
            {
                return HttpNotFound();
            }
            return View(datathing);
        }

        //
        // GET: /Things/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Things/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DataThing datathing)
        {
            if (ModelState.IsValid)
            {
                db.Things.Add(datathing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(datathing);
        }

        //
        // GET: /Things/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DataThing datathing = db.Things.Find(id);
            if (datathing == null)
            {
                return HttpNotFound();
            }
            return View(datathing);
        }

        //
        // POST: /Things/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DataThing datathing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(datathing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(datathing);
        }

        //
        // GET: /Things/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DataThing datathing = db.Things.Find(id);
            if (datathing == null)
            {
                return HttpNotFound();
            }
            return View(datathing);
        }

        //
        // POST: /Things/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DataThing datathing = db.Things.Find(id);
            db.Things.Remove(datathing);
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