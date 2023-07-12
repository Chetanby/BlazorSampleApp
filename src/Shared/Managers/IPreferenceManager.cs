using SampleApp.Shared.Settings;
using System.Threading.Tasks;
using SampleApp.Shared.Wrapper;

namespace SampleApp.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}