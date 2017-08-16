using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject.DependencyInjection;

namespace MVCProject.Controllers
{
    public class MobileController : Controller
    {
        // GET: Mobile
        public ActionResult Index()
        {
            PhoneTypeChecker checker = new PhoneTypeChecker(MANUFACTURERS.SAMSUNG);
            IPhoneFactory factory;
            factory = checker.CheckProducts();
            ViewBag.Samsung = "Samrt: " + factory.GetSmart().Name() + " Feature: " + factory.GetFeature().Name();

            //Console.ReadLine();

            checker = new PhoneTypeChecker(MANUFACTURERS.HTC);

            factory = checker.CheckProducts();
            ViewBag.HTC = "Samrt: " + factory.GetSmart().Name() + " Feature: " + factory.GetFeature().Name();
            //Console.ReadLine();

            checker = new PhoneTypeChecker(MANUFACTURERS.NOKIA);

            factory = checker.CheckProducts();
            ViewBag.Nokia = "Samrt: " + factory.GetSmart().Name() + " Feature: " + factory.GetFeature().Name();
            //Console.Read();
            return View();
        }
    }
}