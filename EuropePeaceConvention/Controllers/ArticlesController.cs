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
using Microsoft.AspNet.Identity;

namespace EuropePeaceConvention.Controllers
{
    [Authorize]
    public class ArticlesController : Controller
    {
        private Context db = new Context();

        // GET: Articles
        public ActionResult Index()
        {
            return View(db.ArticlesModels.ToList());
        }

        // GET: Articles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticlesModels articlesModels = db.ArticlesModels.Find(id);

            var model = new ArticleDetailsViewModels()
            {
                Article = db.ArticlesModels.Find(id),

                Comment = db.CommentModels.Where(m => m.ArticleId == id).ToList()
            };

            if (articlesModels == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Details(string Content, int id)
        {
                var commentModels = new CommentModels();
                commentModels.Content = Content;
                commentModels.PostDate = DateTime.Now;
                commentModels.User = User.Identity.GetUserName();
                commentModels.ArticleId = id;
                db.CommentModels.Add(commentModels);
                db.SaveChanges();
                return RedirectToAction("Index");
        }

        // GET: Articles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Content")] ArticlesModels articlesModels)
        {
            if (ModelState.IsValid)
            {
                articlesModels.User = User.Identity.GetUserName();
                articlesModels.PostDate = DateTime.Now;
                db.ArticlesModels.Add(articlesModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(articlesModels);
        }

        // GET: Articles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticlesModels articlesModels = db.ArticlesModels.Find(id);
            if (articlesModels == null)
            {
                return HttpNotFound();
            }
            return View(articlesModels);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Content")] ArticlesModels articlesModels)
        {
            if (ModelState.IsValid)
            {
                articlesModels.User = User.Identity.GetUserName();
                articlesModels.PostDate = DateTime.Now;
                db.Entry(articlesModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(articlesModels);
        }

        // GET: Articles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticlesModels articlesModels = db.ArticlesModels.Find(id);
            if (articlesModels == null)
            {
                return HttpNotFound();
            }
            return View(articlesModels);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArticlesModels articlesModels = db.ArticlesModels.Find(id);
            db.ArticlesModels.Remove(articlesModels);
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
