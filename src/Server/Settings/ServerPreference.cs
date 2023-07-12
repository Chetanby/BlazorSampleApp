using System.Linq;
using SampleApp.Shared.Constants.Localization;
using SampleApp.Shared.Settings;

namespace SampleApp.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}