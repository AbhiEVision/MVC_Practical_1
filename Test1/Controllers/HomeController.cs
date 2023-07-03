using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Test = "Hello World!";
			return View();
		}

		public ActionResult Test2()
		{
			return View();
		}


	}
}