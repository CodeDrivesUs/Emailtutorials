using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Net;
using Email.Models;
using System.Web.Mvc;

namespace Email.Controllers
{
    public class GmailController : Controller
    {
        // GET: Gmail
        public ActionResult Send()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Send(Gmail gmail)
        {
            gmail.SendMail();
            return View();
        }
    }
}