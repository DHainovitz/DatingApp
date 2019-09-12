using System.Threading.Tasks;
using DatingWebAPI.Models;

namespace DatingWebAPI.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User>  login(string username, string password);
        Task<bool> UserExists(string username);
    }
}