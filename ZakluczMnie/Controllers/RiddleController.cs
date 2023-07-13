using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ZakluczMnie.Data;
using ZakluczMnie.Enums;
using ZakluczMnie.Interfaces;

namespace ZakluczMnie.Controllers
{
    [Authorize]
    public class RiddleController : Controller
    {
        private readonly IRiddleRepository _riddleRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public RiddleController(IRiddleRepository riddleRepository, UserManager<IdentityUser> userManager)
        {
            _riddleRepository = riddleRepository;
            _userManager = userManager;
        }

        public IActionResult Start()
        {
            var userId = _userManager.GetUserAsync(User).Result.Id;
            _riddleRepository.StartUserRiddle(userId, (int)RiddleEnum.Start);
            return View();
        }

        public IActionResult Next()
        {
            var userId = _userManager.GetUserAsync(User).Result.Id;
            _riddleRepository.CompleteUserRiddle(userId, (int)RiddleEnum.Start);
            _riddleRepository.StartUserRiddle(userId, (int)RiddleEnum.Next);
            return View();
        }
    }
}
