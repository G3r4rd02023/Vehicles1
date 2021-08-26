using Vehicles.Models;

namespace Vehicles.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }
}
