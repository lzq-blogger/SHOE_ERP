using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoe_erp.Controllers
{
    public class product_repertoryController : Controller
    {
        // 一级页面=======================================
        //产品库存
        public ActionResult product_repertory()
        {
            return View();
        }
        //产品入库管理
        public ActionResult in_repertory()
        {
            return View();
        }
        //产品出库详情(自行建一个查看单个出库记录详情页面，建议采用模态窗)
        public ActionResult out_repertory()
        {
            return View();
        }
        //产品出库入库统计
        public ActionResult in_out_statistics()
        {
            return View();
        }
        //二级页面================================================================
        //产品库存数量
        public ActionResult add_in_product()
        {
            return View();
        }
        //添加产品入库
        public ActionResult product_repertory_num()
        {
            return View();
        }
        //产品入库单管理
        public ActionResult select_in_product_order()
        {
            return View();
        }
        //产品出库单管理(具体出库生成订单是在销售里面去生成订单，这里面只是一个单纯的
        //查看消息，没有新增)
        public ActionResult select_out_product_order()
        {
            return View();
        }
    }
}