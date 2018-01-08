using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("../RentBook/Details");
            }else
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Renting book service.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Having trouble? Send us a message";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = "Thanks we got your message.";

            return View();
        }

        //public ActionResult Book(int id)
        //{
        //    string[] bookName =  new string[]{ "ASPNETBOOK","Cooking","Bam" };
        //    //            return new HttpStatusCodeResult(403);
        //    //return  Json(new { name = "King Arther", value = "5$" }, JsonRequestBehavior.AllowGet);
        //    return RedirectToAction("Index");
        //}
    }
}