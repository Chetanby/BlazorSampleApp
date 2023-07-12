using AutoMapper;
using SampleApp.Application.Requests.Identity;
using SampleApp.Application.Responses.Identity;

namespace SampleApp.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}