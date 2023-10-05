using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Messages.ToList();
            return View(values);
        }

        public ActionResult MessageDelete(int id)
        {
            var values = c.Messages.Find(id);
            c.Messages.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MessageDetails(int id)
        {
            var values = c.Messages.Find(id);
            return View(values);
        }
    }
}