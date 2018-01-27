using Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log_Example.Controllers
{
    public class HomeController : Controller
    {
        [ActFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}