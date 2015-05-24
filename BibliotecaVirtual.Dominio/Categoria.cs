using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaVirtual.Dominio
{
    [Table("Categoria")]
    public class Categoria : EntityBase
    {
        public string descripcion { get; set; }
    }
}
