using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAboutMe()
        {
            ViewBag.title = c.WhoAmIs.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = c.WhoAmIs.Select(x => x.Description).FirstOrDefault();
            ViewBag.mail = c.Contacts.Select(x => x.Mail).FirstOrDefault();
            ViewBag.nameSurname = c.Contacts.Select(x => x.NameSurname).FirstOrDefault();
            ViewBag.age = c.Contacts.Select(x => x.Age).FirstOrDefault();
            ViewBag.city = c.Contacts.Select(x => x.City).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialAboutMe2()
        {
            return PartialView();
        }

        public PartialViewResult PartialSkillDegree()
        {
            ViewBag.title = c.SkillDescriptions.Select(x => x.SkillDesTitle).FirstOrDefault();
            ViewBag.des = c.SkillDescriptions.Select(x => x.SkillDesTitle).FirstOrDefault();

            var values = c.SkillDegrees.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAchievement()
        {
            var values = c.Achievements.ToList();

            return PartialView(values);
        }

        public ActionResult AboutGetir()
        {
            var values = c.AboutTops.ToList();

            return PartialView(values);
        }

        [HttpGet]
        public ActionResult AboutGuncelle(int id)
        {
            var value = c.AboutTops.Find(id);

            return View(value);
        }
        [HttpPost]
        public ActionResult AboutGuncelle(AboutTop p)
        {
            var value = c.AboutTops.Find(p.AboutTopID);
            value.AdSoyad = p.AdSoyad;
            value.Age = p.Age;
            value.Sehir = p.Sehir;
            value.Mail = p.Mail;
            value.Title = p.Title;
            value.Description = p.Description;
            c.SaveChanges();
            return RedirectToAction("AboutGetir");
        }



        public ActionResult Achievement()
        {
            var values = c.Achievements.ToList();

            return View(values);
        }

        public ActionResult AchievementEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AchievementEkle(Achievement p)
        {
            c.Achievements.Add(p);
            c.SaveChanges();
            return RedirectToAction("Achievement");
        }

        public ActionResult AchievementSil(int id)
        {
            var values = c.Achievements.Find(id);
            c.Achievements.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Achievement");
        }

        [HttpGet]
        public ActionResult AchievementGuncelle(int id)
        {
            var value = c.Achievements.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult AchievementGuncelle(Achievement p)
        {
            var value = c.Achievements.Find(p.AchievementID);
            value.AchievementID = p.AchievementID;
            value.Title = p.Title;
            value.Description = p.Description;
            c.SaveChanges();
            return RedirectToAction("Achievement");
        }

        public ActionResult GetAboutSkill()
        {
            var values = c.SkillDegrees.ToList();
            return View(values);
        }

        public ActionResult DeleteAboutSkill(int id)
        {
            var value = c.SkillDegrees.Find(id);
            c.SkillDegrees.Remove(value);
            c.SaveChanges();
            return RedirectToAction("GetAboutSkill");
        }
        [HttpGet]
        public ActionResult UpdateAboutScill(int id)
        {
            var value = c.SkillDegrees.Find(id);

            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAboutScill(SkillDegree p)
        {
            var value = c.SkillDegrees.Find(p.SkillDegreeID);
            value.Name = p.Name;
            value.Degree = p.Degree;
            c.SaveChanges();
            return RedirectToAction("GetAboutSkill");
        }

        [HttpGet]
        public ActionResult AddAboutSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAboutSkill(SkillDegree p)
        {
            c.SkillDegrees.Add(p);
            c.SaveChanges();
            return RedirectToAction("GetAboutSkill");
        }
    }
}