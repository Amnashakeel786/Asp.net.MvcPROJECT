using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // About page
        public ActionResult About()
        {
            return View();
        }

        // Service page
        public ActionResult Services()
        {
            return View();
        }

        // Contact page
        public ActionResult Contact()
        {
            return View();
        }
    }
}

    }
}