using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Common.Libro
{
    public class LibroDetailViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Descripción")]        
        public string descripcion { get; set; }

        [Display(Name = "Nombre de Autor")]    
        public string nombre_autor { get; set; }

        [Display(Name = "Genero")]
        public string genero { get; set; }

        [Display(Name = "Categoria")]
        public int categoriaid { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }
    }
}
