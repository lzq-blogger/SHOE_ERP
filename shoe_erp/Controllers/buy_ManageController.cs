﻿using System;
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
        //购买材料界面1
        public ActionResult buy_plan()
        {
            return View();
        }
        //购买材料订单2
        public ActionResult buy_order()
        {
            return View();
        }
        //购买材料统计3
        public ActionResult buy_statistical()
        {   
            return View();
        }
        //=============================================================二级
        //查询计划1_1
        public ActionResult select_plan()
        {
            return View();
        }
        //新增采购计划1_1
        public ActionResult add_plan()
        {
            return View();
        }
        //查看材料信息界面
        public ActionResult select_materialr()
        {
            return View();
        }
        //查询采购订单2_1
        public ActionResult select_order()
        {
            return View();
        }
        //新增采购订单
        public ActionResult add_order()
        {
            return View();
        }
        //订单跟踪，样式不是表格，自由发挥，需要有查询，根据订单号
        public ActionResult order_tail()
        {
            return View();
        }
    }
}