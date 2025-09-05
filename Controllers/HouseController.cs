
using Microsoft.AspNetCore.Mvc;
using smart_city_dotnetcore.Models;
using smart_city_dotnetcore.Services;

namespace smart_city_dotnetcore.Controllers
{
    public class HouseController : Controller
    {
        private readonly IHouseService _houseService;
        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }
        public async Task<IActionResult> Index()
        {
            var houses = await _houseService.GetAll();
            return View(houses);
        }
    }
}