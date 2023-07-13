using Microsoft.EntityFrameworkCore;
using ZakluczMnie.Data;
using ZakluczMnie.Interfaces;

namespace ZakluczMnie.Repositories
{
    public class RiddleRepository : Repository<Riddle>, IRiddleRepository
    {
        public RiddleRepository(ApplicationDbContext context) : base(context)
        {

        }

        public List<AspNetUserRiddle> GetUserRiddles(string userId)
        {
            return _context.AspNetUserRiddles.Where(a => a.AspNetUserId == userId).Include("Riddle").ToList();
        }

        public DateTime? GetCurrentRiddleTime(string userId)
        {
            return _context.AspNetUserRiddles.Where(a => a.AspNetUserId == userId).Include("Riddle").OrderBy(a => a.Riddle.Number).FirstOrDefault()?.DateStarted;
        }

        public void CompleteUserRiddle(string userId, int riddleNumber)
        {
            var userRiddles = _context.AspNetUserRiddles.Where(a => a.AspNetUserId == userId).Include("Riddle");
            var riddle = userRiddles.Where(a => a.Riddle.Number == riddleNumber).FirstOrDefault();
            if(riddle != null)
            {
                if(riddle.DateEnded == null)
                {
                    riddle.DateEnded = DateTime.Now;
                }
            }
            else
            {
                if(riddleNumber != 1)
                {
                    CompleteUserRiddle(userId, riddleNumber - 1);
                }
                StartUserRiddle(userId, riddleNumber);
                CompleteUserRiddle(userId, riddleNumber);
            }
        }

        public void StartUserRiddle(string userId, int riddleNumber)
        {
            if(GetUserRiddles(userId).Any(a => a.Riddle.Number == riddleNumber))
            {
                return;
            }
            var riddle = Find(a => a.Number == riddleNumber).FirstOrDefault();
            _context.AspNetUserRiddles.Add(new AspNetUserRiddle()
            {
                AspNetUserId = userId,
                RiddleId = riddle.Id,
                DateStarted = DateTime.Now,
            });
            SaveChanges();
        }
    }
}
