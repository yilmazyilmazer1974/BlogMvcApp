using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home


        private BlogCentext context = new BlogCentext();
        public ActionResult Index()
        {
            return View(context.Bloglar.ToList());
        }
    }
}