using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        //GET : /Helloworld/
        public ActionResult Welcome(string name, int id = 1)
        {
            //return "bonjour le monde";
            ViewBag.message = "Hello" + name;
            ViewBag.numtimes = id;

            return View();
        }
    }
}