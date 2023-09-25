using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PrismWPFHoneys.Business.fakeObjects.svcFake1;
using PrismWPFHoneys.Business.fakeObjects.svcFake2;

namespace Prism_WPF_Honeys.ShellPrism.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<FakeResponse2, FakeResponse1>();
        }
    }
}
