using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIDemo.Data;

namespace DIDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendMessage(string message)
        {
            var emailSvc = new EmailService();
            emailSvc.Send(message);
            return RedirectToAction("Index");
        }
    }
}
