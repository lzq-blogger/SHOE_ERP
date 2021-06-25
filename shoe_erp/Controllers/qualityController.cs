using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class qualityController : Controller
    {
        // 一级界面=======================================
        //待质检产品
        public ActionResult wait_quality_product()
        {
            return View();
        }
        //待质检原料
        public ActionResult wait_quality_materials()
        {
            return View();
        }
        //二级界面====================================================
        //查询产品质检单(在同一个页面需要有个模态窗来进行质检产品，也就是新增质检单)
        public ActionResult select_wait_quality_product()
        {
            return View();
        }
        //查询产品生产（主要查没有质检的）
        public ActionResult select_product_product()
        {
            return View();
        }
        //查询原料质检单(在同一个页面需要有个模态窗来进行质检产品，也就是新增质检单)
        public ActionResult select_wait_quality_materials()
        {
            return View();
        }
        //查询采购订单表（主要查没有质检的）
        public ActionResult select_product_materials()
        {
            return View();
        }
    }
}