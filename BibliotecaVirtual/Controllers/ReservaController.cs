using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibliotecaVirtual.Controllers
{
    public class ReservaController : Controller
    {
        // GET: Reserva
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return null;
        }

        public ActionResult SearchLibro(string nombre = "", string genero = "")
        {
            return null;
        }
    }
}