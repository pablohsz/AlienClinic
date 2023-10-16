using AC.Core.Domain;
using AC.Core.Shared.ModelViews;
using AutoMapper;

namespace AC.Manager.Mappings
{
    public class NewCustomerMappingProfile : Profile
    {

        public NewCustomerMappingProfile()
        {
            CreateMap<NewCustomer, Customer>()
                .ForMember( d => d.Created, o => o.MapFrom(x => DateTime.Now))
                .ForMember(d => d.Birthdate, o => o.MapFrom(x => x.Birthdate.Date));
        }
    }
}
