using System.Text.Json;
using SampleApp.Application.Interfaces.Serialization.Options;

namespace SampleApp.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}