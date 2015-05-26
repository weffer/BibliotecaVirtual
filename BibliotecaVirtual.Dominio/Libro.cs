using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaVirtual.Dominio
{
    [Table("Libro")]
    public class Libro : EntityBase
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string nombre_autor { get; set; }
        public string genero { get; set; }
        public Categoria categoria { get; set; }
        public int cantidad { get; set; }
        public int categoriaId { get; set; }
    }
}
