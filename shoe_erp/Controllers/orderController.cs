using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class orderController : Controller
    {
        // GET: order
        public ActionResult customerOrder_statistical()
        {
            return View();
        }
    }
}