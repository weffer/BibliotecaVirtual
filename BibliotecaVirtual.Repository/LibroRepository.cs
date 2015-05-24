using BibliotecaVirtual.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Repository
{
    public class LibroRepository : BaseRepository<Libro,BibliotecaVirtualContext>
    {
        public LibroRepository(BibliotecaVirtualContext bibliotecaVirtualContext) :base(bibliotecaVirtualContext)  { }
    }
}
