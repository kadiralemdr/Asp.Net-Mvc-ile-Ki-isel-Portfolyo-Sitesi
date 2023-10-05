using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(Service p)
        {
            c.Services.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteService(int id)
        {
            var values = c.Services.Find(id);
            c.Services.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var values = c.Services.Find(id);

            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateService(Service p)
        {
            var values = c.Services.Find(p.ServiceID);
            values.ServiceTitle = p.ServiceTitle;
            values.ServiceNumber = p.ServiceNumber;
            values.ServiceContent = p.ServiceContent;
            values.ServiceIcon = p.ServiceIcon;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}