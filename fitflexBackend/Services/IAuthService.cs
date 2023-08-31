using System.Threading.Tasks;

namespace fitflexBackend.Services
{
    public interface IAuthService
    {
        Task<string> LoginAsync(string email, string password);
        // Add other authentication-related methods as needed
    }
}
