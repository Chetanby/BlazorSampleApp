using SampleApp.Application.Interfaces.Common;
using SampleApp.Application.Requests.Identity;
using SampleApp.Application.Responses.Identity;
using SampleApp.Shared.Wrapper;
using System.Threading.Tasks;

namespace SampleApp.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}