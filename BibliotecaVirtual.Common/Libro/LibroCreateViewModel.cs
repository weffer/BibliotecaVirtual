using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BibliotecaVirtual.Common.Categoria;
using System.Web;

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
      
        public int categoriaid { get; set; }

        [Required(ErrorMessage = "La Cantidad es Requerido")]
        [Display(Name = "Cantidad")]        
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La Cantidad es Requerido")]
        [Display(Name = "Categoria")]        
        public IEnumerable<CategoriaListViewModel> categorias { get; set; }

        public CategoriaListViewModel categoria { get; set; }

        public HttpPostedFileBase file { get; set; }
        public byte[] img { get; set; }
    }
}
