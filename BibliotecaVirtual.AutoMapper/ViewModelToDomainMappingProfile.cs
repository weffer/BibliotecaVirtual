using AutoMapper;
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
          
        }
    }
}
