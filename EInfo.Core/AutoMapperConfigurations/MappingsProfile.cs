using AutoMapper;
using EInfo.Core.Model;
using EInfo.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EInfo.Core.AutoMapperConfigurations
{
    public class MappingsProfile : Profile
    {
        public override string ProfileName => "MappingsProfile";

        public MappingsProfile()
        {
            CreateMap<Deparement, DeparemeentVM>();
            CreateMap<DeparemeentVM, Deparement>();
        }

    }
}
