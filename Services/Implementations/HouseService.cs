using Microsoft.EntityFrameworkCore;
using smart_city_dotnetcore.Data;
using smart_city_dotnetcore.Models;

namespace smart_city_dotnetcore.Services
{
    public class HouseService : IHouseService
    {
        private readonly ApplicationDbContext _context;

        public HouseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<House>> GetAll()
        {
            return await _context.Houses.ToListAsync();
        }

        public async Task<House?> GetById(int id)
        {
            return await _context.Houses.FirstOrDefaultAsync(house => house.Id == id);
        }

        public async Task Add(House house)
        {
            _context.Houses.Add(house);
            await _context.SaveChangesAsync();
        }

        public async Task Update(House house)
        {
            _context.Houses.Update(house);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(House house)
        {
            _context.Houses.Remove(house);
            await _context.SaveChangesAsync();
        }
    }
}