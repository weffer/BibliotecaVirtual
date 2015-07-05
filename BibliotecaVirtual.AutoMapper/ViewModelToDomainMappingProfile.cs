using AutoMapper;
using BibliotecaVirtual.Common.Libro;
using BibliotecaVirtual.Common.Prestamo;
using BibliotecaVirtual.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaVirtual.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Libro, LibroCreateViewModel>();
            Mapper.CreateMap<Libro, LibroListViewModel>();
            Mapper.CreateMap<Libro, LibroEditViewModel>();
            Mapper.CreateMap<Libro, LibroDetailViewModel>(); 
           
            //Prestamo
            Mapper.CreateMap<Prestamo, PrestamoCreateViewModel>();
            Mapper.CreateMap<Prestamo, PrestamoConsultarViewModel>();
        }
    }
}
