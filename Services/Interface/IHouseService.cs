using smart_city_dotnetcore.Models;

namespace smart_city_dotnetcore.Services
{
    public interface IHouseService
    {
        Task<IEnumerable<House>> GetAll();
        Task<House?> GetById(int id);
        Task Add(House house);
        Task Update(House house);
        Task Delete(House house);
    }
}