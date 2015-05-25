using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Common.Libro
{
    public class LibroCreateViewModel
    {
        [Required(ErrorMessage="El Nombre es Requerido")]
        [Display(Name="Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage="La descripción es Requerido")]
        [Display(Name="Descripción")]
        public string descripcion { get; set; }

        [Required(ErrorMessage="El Nombre del Autor es Requerido")]
        [Display(Name="Nombre de Autor")]
        public string nombre_autor { get; set; }

        [Required(ErrorMessage = "El genero es Requerido")]
        [Display(Name = "Genero")]        
        public string genero { get; set; }

        [Required(ErrorMessage = "La Categoria es Requerido")]
        [Display(Name = "Categoria")]        
        public int categoriaid { get; set; }

        [Required(ErrorMessage = "La Cantidad es Requerido")]
        [Display(Name = "Cantidad")]        
        public int Cantidad { get; set; }
    }
}
