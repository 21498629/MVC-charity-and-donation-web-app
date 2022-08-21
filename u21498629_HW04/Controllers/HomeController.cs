using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using u21498629_HW04.Models;

namespace u21498629_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public static List<Donate> money = new List<Donate>();
        public ActionResult Donate()
        {
            return View(money);
        }
        
        [HttpGet]
        public ActionResult Donation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Donation(string name, string surname, string email, int cellphone, bool newsletter, int amount, HttpPostedFileBase file, string items)
        {


            //Function for uploading proof of payment
            if (file != null )
            {

                //save document into proof of payment folder
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Document"), fileName);
                file.SaveAs(path);
            }

            return RedirectToAction("Money");
        }

        public ActionResult Items()
        {
            return View();
        }

        public virtual void CheckInfo()
        {
           
        }
    }
}