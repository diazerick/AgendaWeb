using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAgenda.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult Noticias()
        {
            return View();
        }

        public ActionResult Eventos()
        {
            return View();
        }
        public ActionResult Contacto_y_Soporte()
        {
            return View();
        }

        public ActionResult Iniciar_Sesion()
        {
            return View();
        }

        public ActionResult Cerrar_Sesion()
        {
            return View();
        }

        public ActionResult Sesion_Iniciada()
        {
            return View();
        }

        public ActionResult Soberanias()
        {
            return View();
        }

        public ActionResult Gran_Oriente()
        {
            return View();
        }

        public ActionResult Logia()
        {
            return View();
        }

        public ActionResult Miembros_de_Logia()
        {
            return View();
        }

        public ActionResult Valida_tu_LodgeCard()
        {
            return View();
        }

    }
}