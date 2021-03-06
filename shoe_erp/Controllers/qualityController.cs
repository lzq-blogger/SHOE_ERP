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
        //待质检产品质检单
        public ActionResult wait_quality_product_order()
        {
            return View();
        }
        //待质检材料
        public ActionResult wait_quality_materials()
        {
            return View();
        }
        //待质检材料质检单
        public ActionResult wait_quality_materials_order()
        {
            return View();
        }
        //二级界面====================================================
        //查询产品质检单(在同一个页面需要有个模态窗来进行质检产品，也就是新增质检单)
        public ActionResult select_wait_quality_product()
        {
            return View();
        }
        //查询待检产品（主要查没有质检的）
        public ActionResult select_product_product()
        {
            return View();
        }
        //查询材料质检单(在同一个页面需要有个模态窗来进行质检产品，也就是新增质检单)
        public ActionResult select_wait_quality_materials()
        {
            return View();
        }
        //查询待检材料（主要查没有质检的）
        public ActionResult select_product_materials()
        {
            return View();
        }
    }
}