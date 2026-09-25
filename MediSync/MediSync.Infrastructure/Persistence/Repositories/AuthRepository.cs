using MediSync.Domain.Entities;
using MediSync.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MediSync.Infrastructure.Persistence.Repositories
{
    public class AuthRepository
    {
        private readonly AppDbContext _context;

        public AuthRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<int> CreateAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user.Id;
        }
    }
}