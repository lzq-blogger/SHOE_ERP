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
        //领料管理
        public ActionResult get_materials()
        {
            return View();
        }
        //二级界面====================================
        //查询生产计划
        public ActionResult select_product_plan()
        {
            return View();
        }
        //新增生产计划
        public ActionResult add_product_plan()
        {
            return View();
        }
        //查询领料单
        public ActionResult select_get_materials_order()
        {
            return View();
        }
        //新增领料单
        public ActionResult add_get_materials_order()
        {
            return View();
        }
        //查询产品生产
        public ActionResult select_product_product()
        {
            return View();
        }
        //新增产品生产
        public ActionResult add_product_product()
        {
            return View();
        }
    }
}