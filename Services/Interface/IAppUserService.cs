using smart_city_dotnetcore.Models;

namespace smart_city_dotnetcore.Services
{
    public interface IAppUserService
    {
        Task<IEnumerable<AppUser>> GetAll();
        Task<AppUser?> GetById(int id);
        Task Add(AppUser user);
        Task Update(AppUser user);
        Task Delete(AppUser user);
    }
} 