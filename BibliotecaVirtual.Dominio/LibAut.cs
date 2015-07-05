using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Dominio
{
    [Table("LibAut")]
    public class LibAut : EntityBase
    {        
        public int IdAutor { get; set; }
        public int? IdLibro { get; set; }
        public virtual Autor Autor { get; set; }
        public virtual Libro Libro { get; set; }
    }
}
