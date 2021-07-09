using RestArk.Core.Entities;
using System.Threading.Tasks;

namespace RestArk.Core.Services
{
    public interface IUserService
    {
        Task<User> GetUserAsync(long steamId);
    }
}