using BibliotecaVirtual.Common.Prestamo;
using BibliotecaVirtual.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public PrestamoService _PrestamoService;

        public HomeController(PrestamoService _PrestamoService)
        {
            this._PrestamoService = _PrestamoService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Alertas()
        {
            string alertas = string.Empty;

            List<PrestamoConsultarViewModel> lista = _PrestamoService.GetAll();


            foreach (var item in lista.Where(x=>x.FechaDevolucion<DateTime.Now).ToList())
	        {
                alertas = item.Libro.Titulo + " - " + item.FechaDevolucion.ToString().Substring(0,11)+" la fecha de devolucion ya se éxpiro";
	        }

            return Content(alertas);
        }
    }
}