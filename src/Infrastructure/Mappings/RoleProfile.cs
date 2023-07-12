using AutoMapper;
using SampleApp.Infrastructure.Models.Identity;
using SampleApp.Application.Responses.Identity;

namespace SampleApp.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, SampleAppRole>().ReverseMap();
        }
    }
}