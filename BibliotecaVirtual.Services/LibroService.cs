using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaVirtual.Repository;
using BibliotecaVirtual.Dominio;
using BibliotecaVirtual.Common.Libro;
using AutoMapper;
using BibliotecaVirtual.Common.Categoria;


namespace BibliotecaVirtual.Services
{
    public class LibroService : IDisposable
    {

        public IRepository<Libro> _libroRepository;
        public IRepository<Categoria> _categoriaRepository;

        public LibroService(IRepository<Libro> _libroRepository, IRepository<Categoria> _categoriaRepository)
        {
            this._libroRepository = _libroRepository;
            this._categoriaRepository = _categoriaRepository;
        }

        public void Dispose()
        {
            _libroRepository = null;
        }

        public IEnumerable<CategoriaListViewModel> GetAllCategoria()
        {
            return Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaListViewModel>>(_categoriaRepository.GetAll());
        }

        public int Create(LibroCreateViewModel model) 
        {
           return _libroRepository.Add(Mapper.Map<LibroCreateViewModel, Libro>(model));
        }

        public IEnumerable<LibroListViewModel> GetAll()
        {            
            return Mapper.Map<IEnumerable<Libro>,IEnumerable<LibroListViewModel>>(_libroRepository.GetAll());
        }

        public int Delete(int id)
        {
            return _libroRepository.Remove(_libroRepository.GetById(id));            
        }

        public LibroEditViewModel GetById(int id)
        {
            return Mapper.Map<Libro, LibroEditViewModel>(_libroRepository.GetById(id));
        }

        public LibroDetailViewModel GetDetail(int id)
        {
            return Mapper.Map<Libro, LibroDetailViewModel>(_libroRepository.GetById(id));
        }


        public int Edit(LibroEditViewModel model)
        {
            return _libroRepository.Update(Mapper.Map<LibroEditViewModel, Libro>(model));
        }
    }
}
