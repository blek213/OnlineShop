﻿using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class AdminController : Controller
    {
      
        public ActionResult Room()
        {
            bool CheckAuth = IsAuthenticated();
            if(CheckAuth == true)
            {
                var manager = Session["Manager"].ToString();
                ViewBag.manager = manager;


                return View();
            }
            return RedirectToAction("Login", "Account");     
        }
        
        public ActionResult AddProduct()
        {
            return View();
        }
        public ActionResult ChangeSecreatCombination()
        {
            return View();
        }
        public ActionResult ShowApplies()
        {
            return View();
        }
        public ActionResult AddManager()
        {
            return View();
        }
        public ActionResult ShowStatistic()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignOff()
        {
            return View();
        }



        public bool IsAuthenticated()
        {
            if(Session["Manager"] == null)
            {
                return false;
            }

            return true;
        }



    }
}