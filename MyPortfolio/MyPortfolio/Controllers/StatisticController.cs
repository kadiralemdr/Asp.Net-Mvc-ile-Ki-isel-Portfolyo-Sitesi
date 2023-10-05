using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolio.Models.Entities;
namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        Context c = new Context();
        public ActionResult Index()
        {
            ViewBag.totalBlogCount = c.Blogs.Select(x => x.BlogID).Distinct().Count();
            ViewBag.totalServiceCount = c.Services.Select(x => x.ServiceID).Distinct().Count();
            ViewBag.totalProjectCount = c.Projects.Select(x => x.ProjectID).Distinct().Count();
            return View();
        }
    }
}