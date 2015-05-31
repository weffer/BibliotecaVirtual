using BibliotecaVirtual.Common.Libro;
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
            LibroCreateViewModel model = new LibroCreateViewModel();
            model.categorias = _LibroService.GetAllCategoria();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LibroCreateViewModel model)
        {
            if (model.file.ContentLength > (2 * 1024 * 1024))
            {
                return View();
            }

            if (!(model.file.ContentType == "image/jpeg" || model.file.ContentType == "image/gif"))
            {
                return View();
            }

            byte[] data = new byte[model.file.ContentLength];
            model.file.InputStream.Read(data, 0, model.file.ContentLength);
            model.img = data;
            model.categoriaid = model.categoria.Id;
            
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            LibroEditViewModel _LibroEditViewModel = _LibroService.GetById(id);
            return View(_LibroEditViewModel);
        }

        public ActionResult Edit(LibroEditViewModel model)
        {
            if (_LibroService.Edit(model) > 0)
                TempData["LibroEditSuccess"] = "Se Actualizo Correctamente";
            else
                TempData["LibroEditError"] = "No se Actualizo";

            return RedirectToAction("index");
        }

        public ActionResult Details(int id)
        {
            LibroDetailViewModel _LibroDetailViewModel = _LibroService.GetDetail(id);
            return View(_LibroDetailViewModel);
        }
    }
}