using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Common.Prestamo
{
    public class PrestamoCreateViewModel
    {        
        [Display(Name = "Usuario")]
        public string Username { get; set; }
             
        [Display(Name = "Fecha de Prestamo")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaPrestamo { get; set; }                
        public DateTime FechaDevolucion { get; set; }

        [Required(ErrorMessage = "Ingrese la cantidad de dias")]
        [Display(Name = "Cantidad de dias")]
        public int? DiasPrestamo { get; set; }
        public int IdLibro { get; set; }
        public string Devuelto { get; set; }
    }
}
