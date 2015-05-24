using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaVirtual.Repository;
using BibliotecaVirtual.Dominio;
using BibliotecaVirtual.Common;

namespace BibliotecaVirtual.Services
{
    public class LibroRepository : IDisposable
    {

        public IRepository<Libro> _libroRepository;

        public LibroRepository(IRepository<Libro> _libroRepository)
        {
            this._libroRepository = _libroRepository;
        }

        public void Dispose()
        {
            _libroRepository = null;
        }

        public void Create(LibroCreateViewModel LibroCreateViewModel) 
        {

        }
    }
}
