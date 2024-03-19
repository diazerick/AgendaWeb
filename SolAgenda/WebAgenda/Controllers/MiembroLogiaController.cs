using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAgenda.Controllers
{
    public class MiembroLogiaController : Controller
    {
        public ActionResult Index()
        {
            List<E_MiembroLogia> lista = new List<E_MiembroLogia>();
            try
            {
                lista = N_MiembroLogia.ObtenerTodos();
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
            try
            {
                List<E_Logia> lstLogia = N_Logia.ObtenerTodos();
                ViewBag.lstLogia = new SelectList(lstLogia, "IdLogia", "Logia");
                return View("Agregar");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult Agregar(E_MiembroLogia objMiembro)
        {
            try
            {
                N_MiembroLogia.Agregar(objMiembro);
                TempData["correcto"] = $"El miembro {objMiembro.Nombre} se registro correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult ObtenerParaEditar(int idMiembro)
        {
            try
            {
                E_MiembroLogia miembro = N_MiembroLogia.ObtenerPorId(idMiembro);
                List<E_Logia> lstLogia = N_Logia.ObtenerTodos();
                ViewBag.lstLogia = new SelectList(lstLogia, "IdLogia", "Logia", miembro.IdLogia);
                return View("Editar", miembro);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult Editar(E_MiembroLogia objMiembro)
        {
            try
            {
                N_MiembroLogia.Editar(objMiembro);
                TempData["correcto"] = $"El miembro {objMiembro.Nombre} se edito correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult Borrar(int idMiembro)
        {
            try
            {
                N_MiembroLogia.Borrar(idMiembro);
                TempData["correcto"] = $"El miembro se elimino correctamente.";
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