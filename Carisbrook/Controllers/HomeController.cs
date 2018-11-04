using DemoService.MenuNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carisbrook.Controllers
{
    
    public class HomeController : Controller
    {
        MenuService ms = new MenuService();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OurSchool(int Id)
        {
            ViewBag.message = ms.GetSubMenuById(Id).MenuText;
           
            return View();
        }
       
        public ActionResult MenuSection()
        {
            return PartialView();
        }
    }
}