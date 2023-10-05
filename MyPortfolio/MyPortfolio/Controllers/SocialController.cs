using MyPortfolio.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class SocialController : Controller
    {
        // GET: Social
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Socials.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSocial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSocial(Social p)
        {
            c.Socials.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocial(int id)
        {
            var values = c.Socials.Find(id);
            c.Socials.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSocial(int id)
        {
            var values = c.Socials.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSocial(Social p)
        {
            var values = c.Socials.Find(p.SocialMediaID);
            values.SocialMediaName = p.SocialMediaName;
            values.SocialMediaIcon = p.SocialMediaIcon;
            values.SocialMediaUrl = p.SocialMediaUrl;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}