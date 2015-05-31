using BibliotecaVirtual.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria,BibliotecaVirtualContext>
    {
        public CategoriaRepository(BibliotecaVirtualContext BibliotecaVirtualContext) : base(BibliotecaVirtualContext) { }
    }
}
