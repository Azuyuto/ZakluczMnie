using ZakluczMnie.Interfaces;

namespace ZakluczMnie.Models
{
    public class UserRankViewModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public List<RiddleRankViewModel> Riddles { get; set; }
        public TimeSpan SummaryTime
        {
            get
            {
                var summaryTime = new TimeSpan(0, 0, 0);
                foreach(var item in Riddles)
                {
                    summaryTime += item.Time;
                }

                return summaryTime;
            }
        }

        public UserRankViewModel()
        {
            Riddles = new List<RiddleRankViewModel>();
        }

        public void Initialize(IRiddleRepository riddleRepository)
        {
            Riddles = riddleRepository.GetUserRiddles(UserId).Select(a => new RiddleRankViewModel()
            { 
                Number = a.Riddle.Number,
                Time = ((a.DateEnded ?? DateTime.Now) - a.DateStarted)
            }).ToList();
        }
    }
}
