using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class indexmaxController : Controller
    {
        // GET: indexmax
        public ActionResult Index()
        {
            return View();
        }
        //首页
        public ActionResult Home()
        {
            return View();
        }
    }
}