using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIDemo.Core;

namespace DIDemo.Web.Controllers
{
    public class HomeDIMultiController : Controller
    {
        private IMessagingService[] messageSvc;

        public HomeDIMultiController(IMessagingService[] msg)
        {
            this.messageSvc = msg;
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendMessage(string message)
        {
            foreach(var svc in this.messageSvc)
            {
                Response.Write("SENT WITH: " + svc.GetType() + "<br />");
                svc.Send(message);
            }

            Response.End();

            return RedirectToAction("Index");
        }
    }
}
