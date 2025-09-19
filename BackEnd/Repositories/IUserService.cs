using BackEnd.Models;

namespace BackEnd.Repositories
{
    public interface IUserService
    {
        Task<Account?> GetUserByUsernameAsync(string username);
        Task<Account?> CreateUserAsync(Account user);
        Task<Account?> GetUserByIdAsync(int id);
    }
}
