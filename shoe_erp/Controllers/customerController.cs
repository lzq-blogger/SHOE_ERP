using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class customerController : Controller
    {
        // GET: customer  一级界面
        //客户信息
        public ActionResult customerInfo()
        {
            return View();
        }
        //客户订单
        public ActionResult customerOrder()
        {
            return View();
        }
        //客户订单统计
        public ActionResult customerOrder_statistical()
        {
            return View();
        }

        //二级界面========================================
        //查询用户信息
        public ActionResult select_customerInfo()
        {
            return View();
        }
        //新增用户信息
        public ActionResult add_customerInfo()
        {
            return View();
        }
        //查询客户订单
        public ActionResult select_customerOrder()
        {
            return View();
        }
        //新增客户订单
        public ActionResult add_customerOrder()
        {
            return View();
        }
    }
}