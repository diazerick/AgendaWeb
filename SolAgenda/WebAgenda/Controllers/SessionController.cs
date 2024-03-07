using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAgenda.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login()
        {
            return RedirectToAction("Inicio", "Home");
        }
    }
}