using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAgenda.Controllers
{
    public class LogiaController : Controller
    {
        public ActionResult Index()
        {
            List<E_Logia> lista = new List<E_Logia>();
            try
            {
                lista = N_Logia.ObtenerTodos();
                return View("Consulta", lista);
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

        public ActionResult Agregar(E_Logia objLogia)
        {
            try
            {
                N_Logia.Agregar(objLogia);
                TempData["correcto"] = $"La logia {objLogia.Logia} se registro correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult ObtenerParaEditar(int idLogia)
        {
            try
            {
                E_Logia logia = N_Logia.ObtenerPorId(idLogia);
                return View("Editar", logia);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult Editar(E_Logia objLogia)
        {
            try
            {
                N_Logia.Editar(objLogia);
                TempData["correcto"] = $"La logia {objLogia.Logia} se edito correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult Borrar(int idLogia)
        {
            try
            {
                N_Logia.Borrar(idLogia);
                TempData["correcto"] = $"La logia se elimino correctamente.";
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
