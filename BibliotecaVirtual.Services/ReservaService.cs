using AutoMapper;
using BibliotecaVirtual.Common.Reserva;
using BibliotecaVirtual.Dominio;
using BibliotecaVirtual.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Services
{
    public class ReservaService : IDisposable
    {
        public IRepository<Libro> _libroRepository;

        public ReservaService(IRepository<Libro> _libroRepository)
        {
            this._libroRepository = _libroRepository;
        }

        public List<ReservaListViewModel> GetSearchLibro(string nombre, string genero)
        {
            //IEnumerable<Libro> sa = _libroRepository.Get().AsEnumerable();
            return null;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
