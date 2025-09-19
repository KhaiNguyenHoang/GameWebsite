using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using BackEnd.Utils;

namespace BackEnd.Services
{
    public interface IUserService
    {
        Task<Account?> GetUserByUsernameAsync(string username);
        Task<Account?> CreateUserAsync(Account user);
        Task<Account?> GetUserByIdAsync(int id);
    }

    public class UserService : IUserService
    {
        private readonly DatabaseContext _context;

        public UserService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Account?> GetUserByUsernameAsync(string username)
        {
            return await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(a => a.Username == username);
        }

        public async Task<Account?> CreateUserAsync(Account user)
        {
            // Check if username already exists
            if (await _context.Accounts.AnyAsync(a => a.Username == user.Username))
            {
                return null; // Username already exists
            }

            // Check if email already exists
            if (!string.IsNullOrEmpty(user.Email) &&
                await _context.Accounts.AnyAsync(a => a.Email == user.Email))
            {
                return null; // Email already exists
            }

            _context.Accounts.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Account?> GetUserByIdAsync(int id)
        {
            return await _context.Accounts
                .Include(a => a.Role)
                .FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}

