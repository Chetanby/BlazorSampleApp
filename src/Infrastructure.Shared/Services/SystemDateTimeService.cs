using SampleApp.Application.Interfaces.Services;
using System;

namespace SampleApp.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}