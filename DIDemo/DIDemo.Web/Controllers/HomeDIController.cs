using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIDemo.Core;

namespace DIDemo.Web.Controllers
{
    public class HomeDIController : Controller
    {
        private IMessagingService messageSvc;

        public HomeDIController(IMessagingService msg)
        {
            this.messageSvc = msg;
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendMessage(string message)
        {
            this.messageSvc.Send(message);
            return RedirectToAction("Index");
        }
    }
}
