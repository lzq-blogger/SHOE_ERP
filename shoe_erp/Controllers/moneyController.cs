using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class moneyController : Controller
    {
        // 财务详情
        public ActionResult money_detail()
        {
            return View();
        }
        // 财务统计
        public ActionResult money_statistics()
        {
            return View();
        }
        //二级页面
        // 财务支出详情
        public ActionResult money_detail_in()
        {
            return View();
        }
        // 财务收入详情
        public ActionResult money_detail_out()
        {
            return View();
        }
    }
}