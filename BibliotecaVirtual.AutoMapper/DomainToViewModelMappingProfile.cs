using AutoMapper;
using BibliotecaVirtual.Common.Libro;
using BibliotecaVirtual.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaVirtual.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<LibroCreateViewModel, Libro>();
            Mapper.CreateMap<LibroListViewModel, Libro>();
            Mapper.CreateMap<LibroEditViewModel, Libro>();
            Mapper.CreateMap<LibroDetailViewModel, Libro>();
        }
    }
}
