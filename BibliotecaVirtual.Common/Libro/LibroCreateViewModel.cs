using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web;

namespace BibliotecaVirtual.Common.Libro
{
    public class LibroCreateViewModel
    {
        [Required(ErrorMessage="El Titulo es Requerido")]
        [Display(Name="Titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage="Editorial es Requerido")]
        [Display(Name="Editorial")]
        public string Editorial { get; set; }

        [Required(ErrorMessage="El Area es Requerido")]
        [Display(Name = "Area")]
        public string Area { get; set; }
        
        public HttpPostedFileBase file { get; set; }
        public byte[] Imagen { get; set; }
    }
}
