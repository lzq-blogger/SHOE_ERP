using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class saleController : Controller
    {
        // 一级页面
        //客户订单管理
        public ActionResult customer_order()
        {
            return View();
        }
        //销售订单管理
        public ActionResult sale_order()
        {
            return View();
        }
        //销售统计
        public ActionResult sale_statistics()
        {
            return View();
        }
        //二级页面====================================================
        //查询客户订单  （这里面有出货功能)
        public ActionResult select_customer_order()
        {
            return View();
        }
        //新增产品出库(针对订单进行销售)
        public ActionResult out_repertory_order()
        {
            return View();
        }
    }
}