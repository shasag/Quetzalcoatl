using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuetzalCoatlWeb.DAL;

namespace QuetzalCoatlWeb.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisteredUsers()
        {
            return View("RegisteredUsers", UserDAL.GetUserData());
        }

    }
}
