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
        //public string index()
        //{
        //    return "this is my <b>default</b> action...";
        //}
        //GET: /HelloWorld/Welcome/
        //public string Welcome()
        //{
        //    return "This is the Welcome action method.......";
        //}
        public ActionResult Welcome(string name,int numTimes = 1)
        {
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID:" + id);
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
        public ActionResult Index()
        {
            //return View("/Views/Home/Contact.cshtml");
            //return View("/Views/Home/About.cshtml");
            return View();
        }
    }
}