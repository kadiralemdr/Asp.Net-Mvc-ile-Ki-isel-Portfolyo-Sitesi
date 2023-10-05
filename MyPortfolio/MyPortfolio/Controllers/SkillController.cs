using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Skills.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var value = c.Skills.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult EditSkill(Skill p)
        {
            var value = c.Skills.Find(p.SkillID);
            value.SkillName = p.SkillName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skill p)
        {
            c.Skills.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}