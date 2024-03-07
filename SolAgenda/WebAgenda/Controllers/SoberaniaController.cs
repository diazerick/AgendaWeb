using Entidades;
using Negocio;
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
            List<E_Soberania> lista = new List<E_Soberania>();
            try
            {
                lista = N_Soberania.ObtenerTodos();
                return View("Consulta", lista);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
            
        }
    }
}