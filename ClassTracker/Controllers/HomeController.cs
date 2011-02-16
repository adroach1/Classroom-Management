using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using ClassTracker;

namespace Controllers
{

	[HandleError]
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			ViewData["Message"] = "Welcome to ASP.NET MVC on Mono!";
			return View ();
		}
		
		public JsonResult ClassDetail ()
		{
			Course course = new Course();
			course.Department = "CSC";
			course.Description = "A really cool programming course";
			course.Title = "Proramming for Dummies";
			course.CourseNumber = "101";
			
			
			return Json(course);
		}
	}
}

