using Microsoft.AspNetCore.Identity;

namespace ZakluczMnie.Data
{
    public class AspNetUserRiddle
    {
        public required string AspNetUserId { get; set; }
        public ApplicationUser AspNetUser { get; set; }
        public required Guid RiddleId { get; set; }
        public Riddle Riddle { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }
    }
}
