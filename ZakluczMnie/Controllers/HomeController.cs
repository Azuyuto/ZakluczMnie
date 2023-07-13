using Humanizer.Localisation.TimeToClockNotation;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZakluczMnie.Interfaces;
using ZakluczMnie.Models;
using ZakluczMnie.Repositories;

namespace ZakluczMnie.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IRiddleRepository _riddleRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IRiddleRepository riddleRepository, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
            _riddleRepository = riddleRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rank()
        {
            var vm = new RankViewModel();
            vm.Initialize(_userRepository, _riddleRepository);
            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? statusCode)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}