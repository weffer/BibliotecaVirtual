using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaVirtual.Common.Libro;

namespace BibliotecaVirtual.Common.Prestamo
{
    public class PrestamoConsultarViewModel
    {
        public string Username { get; set; }

        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public string Devuelto { get; set; }

        public LibroListViewModel Libro { get; set; }
    }
}
