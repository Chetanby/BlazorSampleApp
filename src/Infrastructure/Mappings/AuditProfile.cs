using AutoMapper;
using SampleApp.Infrastructure.Models.Audit;
using SampleApp.Application.Responses.Audit;

namespace SampleApp.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}