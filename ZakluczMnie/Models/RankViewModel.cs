using ZakluczMnie.Data;
using ZakluczMnie.Interfaces;

namespace ZakluczMnie.Models
{
    public class RankViewModel
    {
        public List<UserRankViewModel> Users { get; set; }
        public List<Riddle> Riddles { get; set; }

        public RankViewModel()
        {
            Users = new List<UserRankViewModel>();
        }

        public void Initialize(IUserRepository userRepository, IRiddleRepository riddleRepository)
        {
            Users = userRepository.GetAll().Select(a => new UserRankViewModel()
            {
                UserId = a.Id,
                Email = a.Email
            }).ToList();

            Users.ForEach(a => a.Initialize(riddleRepository));
            Riddles = riddleRepository.GetAll().ToList();
        }
    }
}
