using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class PortfolController : Controller
    {
        // GET: Portfol
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Portfols.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdatePortfol(int id)
        {
            var value = c.Portfols.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdatePortfol(Portfol p)
        {
            var value = c.Portfols.Find(p.PortfolID);
            value.PortfolID = p.PortfolID;
            value.AdSoyad = p.AdSoyad;
            value.Meslek = p.Meslek;
            value.Description = p.Description;
            value.ImageURL = p.ImageURL;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}