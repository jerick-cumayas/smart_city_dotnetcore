using Microsoft.AspNetCore.Mvc;
using smart_city_dotnetcore.Services;

namespace smart_city_dotnetcore.Controllers
{
    public class PowerMeterController : Controller
    {
        private readonly IPowerMeterService _powerMeterService;
        public PowerMeterController(IPowerMeterService powerMeterService)
        {
            _powerMeterService = powerMeterService;
        }
        public async Task<IActionResult> Index()
        {
            var powerMeters = await _powerMeterService.GetAll();
            return View(powerMeters);
        }
    }
}