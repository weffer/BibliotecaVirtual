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

        [Required(ErrorMessage = "El Titulo es Requerido")]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El Editorial es Requerido")]
        [Display(Name = "Editorial")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "El Area es Requerido")]
        [Display(Name = "Area")]
        public string Area { get; set; }
    }
}
