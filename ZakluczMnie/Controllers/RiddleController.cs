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

        public IActionResult Nic()
        {
            SetAndContinue(RiddleEnum.Start, RiddleEnum.Nic);
            return View();
        }

        public IActionResult Orzel()
        {
            SetAndContinue(RiddleEnum.Nic, RiddleEnum.Orzel);
            return View();
        }

        public IActionResult StrusAfrykanski()
        {
            SetAndContinue(RiddleEnum.Orzel, RiddleEnum.StrusAfrykanski);
            return View();
        }

        public IActionResult Bajka()
        {
            SetAndContinue(RiddleEnum.StrusAfrykanski, RiddleEnum.Bajka);
            return View();
        }

        public IActionResult Szpaku()
        {
            SetAndContinue(RiddleEnum.Bajka, RiddleEnum.Szpaku);
            return View();
        }

        private void SetAndContinue(RiddleEnum set, RiddleEnum con)
        {
            var userId = _userManager.GetUserAsync(User).Result.Id;
            _riddleRepository.CompleteUserRiddle(userId, (int)set);
            _riddleRepository.StartUserRiddle(userId, (int)con);
        }
    }
}
