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
        public string Index()
        {
            return "Bienvenue sur l'index";
        }
        //GET : /Helloworld/
        public string HelloWorld()
        {
            return "Bonjour le monde";
        }
    }
}