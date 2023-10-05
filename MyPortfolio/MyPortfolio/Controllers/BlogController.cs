using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BlogIndex()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult BlogEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BlogEkle(Blog p)
        {
            if (Request.Files.Count > 0)
            {

                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string ext = Path.GetExtension(Request.Files[0].FileName);
                string url = "~/image/" + fileName + ext;
                Request.Files[0].SaveAs(Server.MapPath(url));
                p.ImageURL = "/image/" + fileName + ext;

            }
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("BlogIndex");
        }

        public ActionResult BlogSil(int id)
        {
            var values = c.Blogs.Find(id);
            c.Blogs.Remove(values);
            c.SaveChanges();
            return RedirectToAction("BlogIndex");
        }

        [HttpGet]
        public ActionResult BlogGuncelle(int id)
        {
            var value = c.Blogs.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult BlogGuncelle(Blog p)
        {
            if (Request.Files.Count > 0)
            {

                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string ext = Path.GetExtension(Request.Files[0].FileName);
                string url = "~/image/" + fileName + ext;
                Request.Files[0].SaveAs(Server.MapPath(url));
                p.ImageURL = "/image/" + fileName + ext;

            }
            var value = c.Blogs.Find(p.BlogID);
            value.BlogID = p.BlogID;
            value.Title = p.Title;
            value.Description = p.Description;
            value.Tarih = p.Tarih;
            value.ImageURL = p.ImageURL;
            //value.Title1 = p.Title1;
            //value.Description1 = p.Description1;
            c.SaveChanges();
            return RedirectToAction("BlogIndex");
        }

        public PartialViewResult PartialSolBlog()
        {
            var values = c.Blogs.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialOrtaBlog()
        {
            var values = c.Blogs.OrderByDescending(x => x.BlogID).Take(1).ToList();
            return PartialView(values);
        }

        public ActionResult BlogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.BlogID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}