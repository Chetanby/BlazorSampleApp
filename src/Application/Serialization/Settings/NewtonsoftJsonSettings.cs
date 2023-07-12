
using SampleApp.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace SampleApp.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}