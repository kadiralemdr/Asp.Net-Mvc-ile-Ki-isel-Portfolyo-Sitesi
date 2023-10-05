using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialPortfol()
        {

            ViewBag.AdSoyad = c.Portfols.Select(x => x.AdSoyad).FirstOrDefault();
            ViewBag.Meslek = c.Portfols.Select(x => x.Meslek).FirstOrDefault();
            ViewBag.Description = c.Portfols.Select(x => x.Description).FirstOrDefault();
            ViewBag.ImageUrl = c.Portfols.Select(x => x.ImageURL).FirstOrDefault();

            return PartialView();
        }

        public PartialViewResult MyResume()
        {
            var values = c.Resumes.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialStatistic()
        {
            ViewBag.totalProjectCount = c.Projects.Count();
            ViewBag.totalBlogCount = c.Blogs.Count();
            ViewBag.totalService = c.Services.Count();
            ViewBag.totalMessage = c.Messages.Count();
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {

            var textArray = c.Skills.Select(x => x.SkillName).ToArray();

            ViewBag.skillArray = textArray;

            return PartialView();
        }


        public PartialViewResult PartialWhoIAm()
        {

            ViewBag.title = c.WhoAmIs.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = c.WhoAmIs.Select(x => x.Description).FirstOrDefault();
            return PartialView();
        }

        public ActionResult Download()
        {
            ViewBag.cv = c.WhoAmIs.Select(x => x.CvLink).FirstOrDefault();
            string filePath = Server.MapPath("~/Templates/" + ViewBag.cv);


            return File(filePath, "application/pdf", ViewBag.cv);
        }

        public PartialViewResult PartialService()
        {

            var values = c.Services.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = c.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialVideo()
        {
            ViewBag.title = c.Videos.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = c.Videos.Select(x => x.Description).FirstOrDefault();
            ViewBag.video = c.Videos.Select(x => x.VideoFrame).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            var values = c.Socials.ToList();
            return PartialView(values);
        }
    }
}