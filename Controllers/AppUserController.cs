using Microsoft.AspNetCore.Mvc;
using smart_city_dotnetcore.Services;

namespace smart_city_dotnetcore.Controllers
{
    public class AppUserController : Controller
    {
        private readonly IAppUserService _appUserService;
        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _appUserService.GetAll();
            return View(users);
        }
    }
}