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

        [Display(Name = "Titulo")]
        public string Titulo { get; set; }

        [Display(Name = "Editorial")]
        public string Editorial { get; set; }

        [Display(Name = "Area")]
        public string Area { get; set; }
       
        [Display(Name="Imagen")]
        public byte[] Imagen { get; set; }
    }
}
