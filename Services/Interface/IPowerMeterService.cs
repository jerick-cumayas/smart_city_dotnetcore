using smart_city_dotnetcore.Models;

namespace smart_city_dotnetcore.Services
{
    public interface IPowerMeterService
    {
        Task<IEnumerable<PowerMeter>> GetAll();
        Task<PowerMeter?> GetById(int id);
        Task Add(PowerMeter meter);
        Task Update(PowerMeter meter);
        Task Delete(PowerMeter meter);
    }
}