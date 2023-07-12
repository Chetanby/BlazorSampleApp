using SampleApp.Application.Requests;

namespace SampleApp.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}