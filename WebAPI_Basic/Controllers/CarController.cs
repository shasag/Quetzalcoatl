﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPI_Basic.Models;

namespace WebAPI_Basic.Controllers
{
    public class CarController : Controller
    {
        //
        // GET: /Car/

        public ActionResult Index()
        {
            return View("CarStock");
        }

    }
}
