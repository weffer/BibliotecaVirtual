using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Dominio
{
    [Table("Prestamo")]
    public class Prestamo : EntityBase
    {
        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        public int IdLibro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaPrestamo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaDevolucion { get; set; }

        [StringLength(1)]
        public string Devuelto { get; set; }

        public virtual Libro Libro { get; set; }
    }
}
