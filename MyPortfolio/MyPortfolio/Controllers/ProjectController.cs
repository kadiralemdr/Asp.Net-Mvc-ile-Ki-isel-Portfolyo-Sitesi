using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Projects.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(Project p)
        {
            c.Projects.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProject(int id)
        {
            var values = c.Projects.Find(id);
            c.Projects.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = c.Projects.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateProject(Project p)
        {
            var values = c.Projects.Find(p.ProjectID);
            values.Title = p.Title;
            values.Description = p.Description;
            values.Tarih = p.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public PartialViewResult PartialProject()
        {
            var values = c.Projects.ToList();
            return PartialView(values);
        }
    }
}