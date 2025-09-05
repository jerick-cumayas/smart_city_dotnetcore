using Microsoft.EntityFrameworkCore;
using smart_city_dotnetcore.Data;
using smart_city_dotnetcore.Models;

namespace smart_city_dotnetcore.Services
{
    public class PowerMeterService : IPowerMeterService
    {
        private readonly ApplicationDbContext _context;

        public PowerMeterService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PowerMeter>> GetAll()
        {
            return await _context.PowerMeters.ToListAsync();
        }

        public async Task<PowerMeter?> GetById(int id)
        {
            return await _context.PowerMeters.FirstOrDefaultAsync(meter => meter.Id == id);
        }

        public async Task Add(PowerMeter meter)
        {
            _context.PowerMeters.Add(meter);
            await _context.SaveChangesAsync();
        }

        public async Task Update(PowerMeter meter)
        {
            _context.PowerMeters.Update(meter);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(PowerMeter meter)
        {
            _context.PowerMeters.Remove(meter);
            await _context.SaveChangesAsync();
        }
    }
}