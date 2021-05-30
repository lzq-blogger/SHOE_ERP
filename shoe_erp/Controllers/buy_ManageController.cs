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
        //购买原料界面
        public ActionResult buy_Material()
        {
            return PartialView();
        }
        //购买原料界面
        public ActionResult buy_plan()
        {
            return PartialView();
        }
        //购买原料订单
        public ActionResult buy_order()
        {
            return View();
        }
        //购买原料统计
        public ActionResult buy_statistical()
        {
            return View();
        }
    }
}