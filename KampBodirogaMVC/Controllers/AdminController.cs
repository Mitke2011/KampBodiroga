using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KampBodirogaMVC.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        //POST /Admin/
        [HttpPost]
        public ViewResult LogIn(string username, string password)
        {

            //return View("..//Visitor//Success");
            return View(@"../View1");
        }

    }
}
