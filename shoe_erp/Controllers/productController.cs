using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class productController : Controller
    {
        // GET: product 一级界面=================
        //生产计划
        public ActionResult product_plan()
        {
            return View();
        }
        //产品生产
        public ActionResult product_product()
        {
            return View();
        }
        //二级界面====================================
        public ActionResult select_product_plan()
        {
            return View();
        }
        public ActionResult add_product_plan()
        {
            return View();
        }
    }
}