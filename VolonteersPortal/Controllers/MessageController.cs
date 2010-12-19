using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolonteersPortal.Controllers
{
    public class MessageController : Controller
    {
        //
        // GET: /Message/


        public ActionResult Received()
        {
            return View();
        }
        public ActionResult Sent()
        {
            return View();
        }
        public ActionResult Read(int Id)
        {
            return View();
        }

        public ActionResult Create(int RecepientId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int RecepientId, string text)
        {
            return View();
        }

        public ActionResult History(int PersonId)
        {
            return View();
        }

    }
}
