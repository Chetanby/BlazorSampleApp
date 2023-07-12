using SampleApp.Application.Requests.Mail;
using System.Threading.Tasks;

namespace SampleApp.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}