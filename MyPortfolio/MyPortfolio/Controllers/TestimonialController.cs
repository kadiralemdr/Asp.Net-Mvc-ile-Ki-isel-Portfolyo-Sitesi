using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestimonial(Testimonial p)
        {
            if (Request.Files.Count > 0)
            {

                string fileName = Path.GetFileName(Request.Files[0].FileName);
                string ext = Path.GetExtension(Request.Files[0].FileName);
                string url = "~/image/" + fileName + ext;
                Request.Files[0].SaveAs(Server.MapPath(url));
                p.ImageURL = "/image/" + fileName + ext;

            }
            c.Testimonials.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var values = c.Testimonials.Find(id);
            c.Testimonials.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = c.Testimonials.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial p)
        {
            var values = c.Testimonials.Find(p.TestimonialID);
            values.NameSurname = p.NameSurname;
            values.TestimonialContent = p.TestimonialContent;
            values.Country = p.Country;
            values.ImageURL = p.ImageURL;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}