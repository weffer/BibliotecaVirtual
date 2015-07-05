using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Dominio
{
    [Table("Autor")]
    public class Autor
    {
        public Autor() //casa
        {
            LibAut = new HashSet<LibAut>();
        }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string Nacionalidad { get; set; }

        public string Edad { get; set; }

        public virtual ICollection<LibAut> LibAut { get; set; }
    }
}
