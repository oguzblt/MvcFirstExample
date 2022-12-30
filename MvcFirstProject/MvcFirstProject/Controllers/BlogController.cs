using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcFirstProject.Models;

namespace MvcFirstProject.Controllers
{
    public class BlogController : Controller
    {
        private Context db = new Context();
        //List methodu yan tarafta bulunan side bar içinde filtreleme yapar.
        public ActionResult List(int? id, string key)
        {
            var bloglar = db.Blogs.Where(i => i.Statu == true && i.HomePage == true).Select(i => new BlogModel()
            {
                Id = i.Id,
                BlogName = i.BlogName,
                Description= i.Description,
                Date= i.Date,
                HomePage= i.HomePage,
                Statu= i.Statu,
                Image= i.Image,
                CategoryId= i.CategoryId,
            }).AsQueryable();
            if (string.IsNullOrEmpty(key)==false)
            {
                bloglar=bloglar.Where(i => i.BlogName.Contains(key) || i.Description.Contains(key));
            }
            if ( id != null)
            {
                bloglar = bloglar.Where(i => i.CategoryId== id);
            }
            return View(bloglar);
        }
       
        // GET: Blog
        public ActionResult Index()
        {
            var blogs = db.Blogs.Include(b => b.Category).OrderByDescending(i => i.Date);
            return View(blogs.ToList());
        }

        // GET: Blog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName");
            return View();
        }

        // POST: Blog/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BlogName,Description,Image,Contents,CategoryId")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                blog.Statu=false;
                blog.HomePage=false;
                blog.Date=DateTime.Now;
                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", blog.CategoryId);
            return View(blog);
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", blog.CategoryId);
            return View(blog);
        }

        // POST: Blog/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BlogName,Description,Image,Contents,Statu,HomePage,CategoryId")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Blogs.Find(blog.Id);
                if (entity != null)
                {
                    entity.BlogName = blog.BlogName;
                    entity.Description = blog.Description;
                    entity.Image = blog.Image;
                    entity.Contents = blog.Contents;
                    entity.Statu = blog.Statu;
                    entity.HomePage = blog.HomePage;
                    entity.CategoryId = blog.CategoryId;

                    db.SaveChanges();
                    TempData["Blog"] = entity;

                    return RedirectToAction("Index");
                }
                db.Entry(blog).State = EntityState.Modified;
                
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", blog.CategoryId);
            return View(blog);
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blog blog = db.Blogs.Find(id);
            db.Blogs.Remove(blog);
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
