using System.Threading.Tasks;
using RetailManagementDesktopUI.Models;

namespace RetailManagementDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}