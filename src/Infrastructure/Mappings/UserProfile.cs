using AutoMapper;
using SampleApp.Infrastructure.Models.Identity;
using SampleApp.Application.Responses.Identity;

namespace SampleApp.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, SampleAppUser>().ReverseMap();
        }
    }
}