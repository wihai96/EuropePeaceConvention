using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EuropePeaceConvention;
using EuropePeaceConvention.Models;

namespace EuropePeaceConvention.Controllers
{
    [Authorize]
    public class CountriesController : Controller
    {
        private Context db = new Context();

        // GET: Countries
        public ActionResult Index()
        {
            return View(db.CountriesModels.ToList());
        }

        // GET: Countries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CountriesModels countriesModels = db.CountriesModels.Find(id);
            if (countriesModels == null)
            {
                return HttpNotFound();
            }
            return View(countriesModels);
        }

        // GET: Countries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Countries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ISO3,Population,Area,HourHashCode")] CountriesModels countriesModels)
        {
            if (ModelState.IsValid)
            {
                db.CountriesModels.Add(countriesModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(countriesModels);
        }

        // GET: Countries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CountriesModels countriesModels = db.CountriesModels.Find(id);
            if (countriesModels == null)
            {
                return HttpNotFound();
            }
            return View(countriesModels);
        }

        // POST: Countries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ISO3,Population,Area,HourHashCode")] CountriesModels countriesModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(countriesModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(countriesModels);
        }

        // GET: Countries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CountriesModels countriesModels = db.CountriesModels.Find(id);
            if (countriesModels == null)
            {
                return HttpNotFound();
            }
            return View(countriesModels);
        }

        // POST: Countries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CountriesModels countriesModels = db.CountriesModels.Find(id);
            db.CountriesModels.Remove(countriesModels);
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
