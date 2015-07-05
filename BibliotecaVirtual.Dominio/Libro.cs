using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Dominio
{
    [Table("Libro")]
    public class Libro : EntityBase
    {
        public Libro()
        {
            //LibAut = new HashSet<LibAut>();
            Prestamo = new HashSet<Prestamo>();
        }
        

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(100)]
        public string Editorial { get; set; }

        [Required]
        [StringLength(100)]
        public string Area { get; set; }

        [Required]
        public byte[] Imagen { get; set; }

        //public virtual ICollection<LibAut> LibAut { get; set; }

        public virtual ICollection<Prestamo> Prestamo { get; set; }
    }
}
