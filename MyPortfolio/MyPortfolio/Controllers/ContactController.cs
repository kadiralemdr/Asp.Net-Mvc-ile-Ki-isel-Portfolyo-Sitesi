using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.phone = c.Contacts.Select(x => x.Phone).FirstOrDefault();
            ViewBag.mail = c.Contacts.Select(x => x.Mail).FirstOrDefault();
            ViewBag.adrress = c.Contacts.Select(x => x.Adrress).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Message p)
        {
            c.Messages.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index", "Portfolio");
        }
        [HttpGet]
        public ActionResult Get()
        {
            var values = c.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var values = c.Contacts.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateContact(Contact p)
        {
            var value = c.Contacts.Find(p.ContactID);
            value.NameSurname = p.NameSurname;
            value.Adrress = p.Adrress;
            value.Age = p.Age;
            value.City = p.City;
            value.Phone = p.Phone;
            value.Mail = p.Mail;
            c.SaveChanges();
            return RedirectToAction("Get");
        }
    }
}