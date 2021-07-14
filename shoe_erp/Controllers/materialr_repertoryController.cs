using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class materialr_repertoryController : Controller
    {
        // 一级页面=======================================
        //材料库存
        public ActionResult materialr_repertory()
        {
            return View();
        }
        //材料入库详情
        public ActionResult in_repertory()
        {
            return View();
        }
        //材料出库详情(自行建一个查看单个出库记录详情页面，建议采用模态窗)
        public ActionResult out_repertory()
        {
            return View();
        }
        //材料出库入库统计
        public ActionResult in_out_statistics()
        {
            return View();
        }
        //二级页面================================================================
        //产品库存
        public ActionResult select_materialr()
        {
            return View();
        }
        //新增材料信息
        public ActionResult add_materialr()
        {
            return View();
        }
        //查询材料入库详情
        public ActionResult select_materialr_in()
        {
            return View();
        }
        
        //新增材料入库
        public ActionResult add_in_materialr()
        {
            return View();
        }

        //材料入库单显示
        public ActionResult select_in_materialr_order()
        {
            return View();
        }


        //查询材料出库详情
        public ActionResult select_materialr_out()
        {
            return View();
        }
    }
}