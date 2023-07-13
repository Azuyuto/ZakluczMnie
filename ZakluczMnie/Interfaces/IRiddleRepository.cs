using ZakluczMnie.Data;

namespace ZakluczMnie.Interfaces
{
    public interface IRiddleRepository : IRepository<Riddle>
    {
        List<AspNetUserRiddle> GetUserRiddles(string userId);
        DateTime? GetCurrentRiddleTime(string userId);
        void CompleteUserRiddle(string userId, int riddleNumber);
        void StartUserRiddle(string userId, int riddleNumber);
    }
}
