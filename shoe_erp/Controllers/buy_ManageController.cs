using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class buy_ManageController : Controller
    {
        //首页
        public ActionResult Home()
        {
            return View();
        }
        // GET: buy_Material
        //购买原料界面1
        public ActionResult buy_plan()
        {
            return View();
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
        //=============================================================二级
        //查询1_1
        public ActionResult select_plan()
        {
            return View();
        }
        //新增采购
        public ActionResult add_plan()
        {
            return View();
        }
        //查询2_1
        public ActionResult select_order()
        {
            return View();
        }
    }
}