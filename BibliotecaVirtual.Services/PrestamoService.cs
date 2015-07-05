using AutoMapper;
using BibliotecaVirtual.Common.Prestamo;
using BibliotecaVirtual.Dominio;
using BibliotecaVirtual.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Services
{
    public class PrestamoService : IDisposable
    {
        public IRepository<Prestamo> _prestamoRepository;

        public PrestamoService(IRepository<Prestamo> _prestamoRepository)
        {
            this._prestamoRepository = _prestamoRepository;
        }

        public void Dispose()
        {
            this._prestamoRepository = null;
        }

        public int Create(PrestamoCreateViewModel model)
        {            
            return this._prestamoRepository.Add(Mapper.Map<PrestamoCreateViewModel, Prestamo>(model));
        }

        public List<PrestamoConsultarViewModel> ConsultarPrestamos(string username)
        {
            return Mapper.Map<IEnumerable<Prestamo>, IEnumerable<PrestamoConsultarViewModel>>(this._prestamoRepository.Get().Where(x => x.Username.ToUpper()==username.ToUpper())).ToList<PrestamoConsultarViewModel>();
        }

        public List<PrestamoConsultarViewModel> GetAll(){
            return Mapper.Map<IEnumerable<Prestamo>, IEnumerable<PrestamoConsultarViewModel>>(this._prestamoRepository.GetAll()).ToList<PrestamoConsultarViewModel>();
        }

    }
}
