using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/

        public ActionResult Index()
        {
            return View();
        }


        // can't overload functions
        public ActionResult SomethingElse(int i)
        {
            ViewBag.Times = i;
            ViewBag.Something = "nothing";
            return View();
        }
    }
}
