using SampleApp.Application.Interfaces.Common;

namespace SampleApp.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}