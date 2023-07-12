using AutoMapper;
using SampleApp.Application.Requests.Identity;
using SampleApp.Application.Responses.Identity;
using SampleApp.Infrastructure.Models.Identity;

namespace SampleApp.Infrastructure.Mappings
{
    public class RoleClaimProfile : Profile
    {
        public RoleClaimProfile()
        {
            CreateMap<RoleClaimResponse, SampleAppRoleClaim>()
                .ForMember(nameof(SampleAppRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(SampleAppRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimRequest, SampleAppRoleClaim>()
                .ForMember(nameof(SampleAppRoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(SampleAppRoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();
        }
    }
}