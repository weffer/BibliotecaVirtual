﻿using BibliotecaVirtual.Common.Libro;
using BibliotecaVirtual.Helpers;
using BibliotecaVirtual.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaVirtual.Controllers
{
    public class LibroController : Controller
    {
        public LibroService _LibroService;

        public LibroController(LibroService _LibroService)
        {
            this._LibroService = _LibroService;
        }
        // GET: Libro
        public ActionResult Index()
        {
            IEnumerable<LibroListViewModel> _ListViewModel = _LibroService.GetAll();
            return View(_ListViewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LibroCreateViewModel model)
        {
            if (_LibroService.Create(model) > 0)
                TempData["LibroCreateSuccess"] = "Se Registro Correctamente";
            else
                TempData["LibroCreateError"] = "No se Registro";

            return RedirectToAction("index");
        }


        public ActionResult Delete(int id)
        {
            if(_LibroService.Delete(id)>0)
                TempData["LibroDeleteSuccess"] = "Se Elimino Correctamente";
            else
                TempData["LibroDeleteError"] = "No se Elimino";

            return RedirectToAction("index");
        }

    }
}