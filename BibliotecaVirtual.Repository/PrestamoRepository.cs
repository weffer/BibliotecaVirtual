using BibliotecaVirtual.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Repository
{
    public class PrestamoRepository : BaseRepository<Prestamo, BibliotecaVirtualContext>
    {
        public PrestamoRepository(BibliotecaVirtualContext bibliotecaVirtualContext) :base(bibliotecaVirtualContext) { }
    }
}
