using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = c.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["usertravel"] = values.Username.ToString();
                return RedirectToAction("Index", "WhoAmI");
            }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre. Lütfen tekrar deneyin.";
                return View();
            }
        }

        public ActionResult Get()
        {
            var values = c.Admins.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminEkle(Admin p)
        {
            c.Admins.Add(p);
            c.SaveChanges();
            return RedirectToAction("Get");
        }

        public ActionResult AdminSil(int id)
        {
            var values = c.Admins.Find(id);
            c.Admins.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Get");
        }

        [HttpGet]
        public ActionResult AdminGuncelle(int id)
        {
            var value = c.Admins.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult AdminGuncelle(Admin p)
        {
            var value = c.Admins.Find(p.AdminID);
            value.AdminID = p.AdminID;
            value.Username = p.Username;
            value.Password = p.Password;
            c.SaveChanges();
            return RedirectToAction("Get");
        }
    }
}