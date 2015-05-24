using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Common
{
    public class LibroCreateViewModel
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string nombre_autor { get; set; }
        public string genero { get; set; }
        public int categoriaid { get; set; }
    }
}
