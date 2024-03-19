﻿using Entidades;
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

        public ActionResult Agregar(E_Soberania objSoberania)
        {
            try
            {
                N_Soberania.Agregar(objSoberania);
                TempData["correcto"] = $"La soberania {objSoberania.Soberania} se registro correctamente.";
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

        public ActionResult Editar(E_Soberania objSoberania)
        {
            try
            {
                N_Soberania.Editar(objSoberania);
                TempData["correcto"] = $"La soberania {objSoberania.Soberania} se edito correctamente.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                return View("_Error");
            }
        }

        public ActionResult Borrar(int idSoberania)
        {
            try
            {
                N_Soberania.Borrar(idSoberania);
                TempData["correcto"] = $"La soberania se elimino correctamente.";
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