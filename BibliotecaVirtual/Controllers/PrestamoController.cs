using BibliotecaVirtual.Common.Libro;
using BibliotecaVirtual.Common.Prestamo;
using BibliotecaVirtual.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaVirtual.Controllers
{
    public class PrestamoController : Controller
    {
        public LibroService _LibroService;
        public PrestamoService _PrestamoService;



        public PrestamoController(LibroService _LibroService, PrestamoService _PrestamoService)
        {
            this._LibroService = _LibroService;
            this._PrestamoService = _PrestamoService;
        }

        // GET: Prestamo
        public ActionResult Index()
        {
            IEnumerable<LibroListViewModel> _ListViewModel = _LibroService.GetAll();
            return View(_ListViewModel);            
        }

        [HttpPost]
        public ActionResult Generar(string[] ids)
        {            

            int[] id = null;
            if (ids != null)
            {
                id = new int[ids.Length];
                int j = 0;
                foreach (string i in ids)
                {
                    int.TryParse(i, out id[j++]);
                }
            }
            else
            {
                TempData["PrestamoSinSeleccionar"] = "Debe Seleccionar por lo menos un libro";
                return RedirectToAction("Index");
            }

            if (id != null && id.Length > 0)
            {              
                Session[User.Identity.Name] = _LibroService.GetAll().Where(x => id.Contains(x.Id)).ToList();               
                return RedirectToAction("FinalizarPrestamo");
            }

            return View();
         
        }

        [HttpGet]
        public ActionResult FinalizarPrestamo()
        {
            PrestamoCreateViewModel _prestamoCreateViewModel = new PrestamoCreateViewModel();
            _prestamoCreateViewModel.Username = User.Identity.Name;
            _prestamoCreateViewModel.FechaPrestamo = DateTime.Now;
            _prestamoCreateViewModel.Devuelto = "N";
            return View(_prestamoCreateViewModel);
        }

        [HttpPost]
        public ActionResult FinalizarPrestamo(PrestamoCreateViewModel model)
        {
            int resultado = 0;
            List<LibroListViewModel> allSelected = Session[User.Identity.Name] as List<LibroListViewModel>;
            model.FechaDevolucion = model.FechaPrestamo.AddDays(Convert.ToDouble(model.DiasPrestamo));

            foreach (var item in allSelected)
            {
                model.IdLibro = item.Id;
                resultado = _PrestamoService.Create(model);
            }
            if (resultado > 0)
                TempData["PrestamoCreateSuccess"] = "Se Genero el Prestamo";
            else
                TempData["PrestamoCreateError"] = "No Se Registro";

            return RedirectToAction("Index");
        }

        public ActionResult Consultar(string titulo = "")
        {
            IEnumerable<LibroListViewModel> _ListViewModel = _LibroService.GetAll().Where(x=>x.Titulo.ToUpper().Contains(titulo.ToUpper())).AsEnumerable();
            return PartialView("Partial/ConsultarLibroPartialView", _ListViewModel);
        }


        public ActionResult ConsultarPrestamo()
        {
            List<PrestamoConsultarViewModel> model = this._PrestamoService.ConsultarPrestamos(User.Identity.Name);
            return View(model);
        }
        
    }
}