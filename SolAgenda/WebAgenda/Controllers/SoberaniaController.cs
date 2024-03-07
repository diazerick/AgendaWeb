using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAgenda.Controllers
{
    public class SoberaniaController : Controller
    {
        // GET: Soberania
        public ActionResult Index()
        {
            return View("Consulta");
        }
    }
}