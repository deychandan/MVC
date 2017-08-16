using MVCProject.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        IErrorLogger logger = new EventViewerLogger();

        public ActionResult Index()
        {
            try
            {
                int firstNumber = 15, secondNumber = 0, result;
                result = firstNumber / secondNumber;
                Console.WriteLine("Result is :{0}", result);
            }
            catch (DivideByZeroException ex)
            {
                logger.LogMessage(ex);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}