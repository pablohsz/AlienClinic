using AC.Core.Domain;
using AC.Core.Shared.ModelViews;
using AutoMapper;

namespace AC.Manager.Mappings
{
    public class AlterCustomerMappingProfile : Profile
    {
         public AlterCustomerMappingProfile()
        {
            CreateMap<AlterCustomer, Customer>()
               .ForMember(dest => dest.Updated, opt => opt.MapFrom(src => DateTime.Now))               
               .ForMember(d => d.Birthdate, o => o.MapFrom(x => x.Birthdate.Date));
        }
    }
}
