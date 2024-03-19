using Entidades;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAgenda.Controllers
{
    public class GranOrienteController : Controller
    {
        // GET: GranOriente
        public ActionResult Index()
        {
            List<E_GranOriente> lista = new List<E_GranOriente>();
            try
            {
                lista = N_GranOriente.ObtenerTodos();
                return View("Consulta", lista);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult ObtenerParaEditar(int idGranOriente)
        {
            try
            {
                E_GranOriente oriente = N_GranOriente.ObtenerPorId(idGranOriente);
                return View("Editar", oriente);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult IrAgregar()
        {
            return View("Agregar");
        }

        public ActionResult Agregar(E_GranOriente objOriente)
        {
            try
            {
                N_GranOriente.Agregar(objOriente);
                TempData["correcto"] = $"El gran oriente {objOriente.Oriente} se registro correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult Editar(E_GranOriente objGranOriente)
        {
            try
            {
                N_GranOriente.Editar(objGranOriente);
                TempData["correcto"] = $"El gran oriente {objGranOriente.Oriente} se edito correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult Borrar(int idGranOriente)
        {
            try
            {
                N_GranOriente.Borrar(idGranOriente);
                TempData["correcto"] = $"El gran oriente se elimino correctamente.";
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
            return RedirectToAction("Index");
        }
    }
}