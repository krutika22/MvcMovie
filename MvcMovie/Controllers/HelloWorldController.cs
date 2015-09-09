using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string Name, int numtimes)
        {
            //return HttpUtility.HtmlEncode("Hello " + Name + ", Numtimes is:" + numtimes);
            ViewBag.Message = "Hello " + Name;
            ViewBag.NumTimes = numtimes;

            return View();
        }
        
    }
}