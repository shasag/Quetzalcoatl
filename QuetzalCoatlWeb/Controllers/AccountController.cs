﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuetzalCoatlWeb.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Register/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

    }
}
