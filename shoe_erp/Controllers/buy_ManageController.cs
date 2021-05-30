using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class buy_ManageController : Controller
    {
        // GET: buy_Material
        //购买原料界面1
        public ActionResult buy_plan()
        {
            return PartialView();
        }
        //购买原料订单2
        public ActionResult buy_order()
        {
            return View();
        }
        //购买原料统计3
        public ActionResult buy_statistical()
        {
            return View();
        }
        //查询1_1
        public ActionResult select_plan()
        {
            return View();
        }
    }
}