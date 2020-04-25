using System.Threading.Tasks;
using DatingApp.Api.Models;

namespace DatingApp.Api.Data
{
    public interface IAuthRepository
    {
         Task<User> Regsiter(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}