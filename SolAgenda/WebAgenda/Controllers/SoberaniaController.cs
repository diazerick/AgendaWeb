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

        public ActionResult IrAgregar()
        {
            return View("Agregar");
        }

        public ActionResult Agregar(string Soberania, string Responsable, string Cargo, string Telefono, string Correo, string Direccion)
        {
            try
            {
                E_Soberania soberania = new E_Soberania
                {
                    Soberania = Soberania,
                    Responsable = Responsable,
                    Cargo = Cargo,
                    Telefono = Telefono,
                    Correo = Correo,
                    Direccion = Direccion
                };
                N_Soberania.Agregar(soberania);
                TempData["correcto"] = $"La soberania {soberania.Soberania} se registro correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult ObtenerParaEditar(int idSoberania)
        {
            try
            {
                E_Soberania soberania = N_Soberania.ObtenerPorId(idSoberania);
                return View("Editar", soberania);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult Editar(int IdSoberania, string Soberania, string Responsable, string Cargo, string Telefono, string Correo, string Direccion)
        {
            try
            {
                E_Soberania soberania = new E_Soberania
                {
                    IdSoberania = IdSoberania,
                    Soberania = Soberania,
                    Responsable = Responsable,
                    Cargo = Cargo,
                    Telefono = Telefono,
                    Correo = Correo,
                    Direccion = Direccion
                };
                N_Soberania.Editar(soberania);
                TempData["correcto"] = $"La soberania {soberania.Soberania} se edito correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }
    }
}