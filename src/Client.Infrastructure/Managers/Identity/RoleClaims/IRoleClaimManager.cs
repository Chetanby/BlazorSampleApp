using System.Collections.Generic;
using System.Threading.Tasks;
using SampleApp.Application.Requests.Identity;
using SampleApp.Application.Responses.Identity;
using SampleApp.Shared.Wrapper;

namespace SampleApp.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}