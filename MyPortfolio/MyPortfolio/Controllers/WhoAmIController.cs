using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class WhoAmIController : Controller
    {
        // GET: WhoAmI
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.WhoAmIs.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult UpdateWhoAmI(int id)
        {
            var value = c.WhoAmIs.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateWhoAmI(WhoAmI p)
        {
            var value = c.WhoAmIs.Find(p.WhoID);
            value.Title = p.Title;
            value.Description = p.Description;
            value.CvLink = p.CvLink;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}