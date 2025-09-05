using Microsoft.EntityFrameworkCore;
using smart_city_dotnetcore.Data;
using smart_city_dotnetcore.Models;

namespace smart_city_dotnetcore.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly ApplicationDbContext _context;

        public AppUserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<AppUser>> GetAll()
        {
            return await _context.AppUsers.ToListAsync();
        }

        public async Task<AppUser?> GetById(int id)
        {
            return await _context.AppUsers.FirstOrDefaultAsync(user => user.Id == id);
        }
        public async Task Add(AppUser user)
        {
            _context.AppUsers.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task Update(AppUser user)
        {
            _context.AppUsers.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(AppUser user)
        {
            _context.AppUsers.Remove(user);
            await _context.SaveChangesAsync();
        }        
    }
}