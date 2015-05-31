using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Common.Libro
{
    public class LibroListViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Display(Name="Descripción")]
        public string descripcion { get; set; }

        [Display(Name = "Nombre de Autor")]
        public string nombre_autor { get; set; }

        [Display(Name = "Genero")]
        public string genero { get; set; }

        [Display(Name = "Cantidad")]
        public int cantidad { get; set; }

        [Display(Name="Imagen")]
        public byte[] img { get; set; }
    }
}
