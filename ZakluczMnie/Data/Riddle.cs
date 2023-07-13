namespace ZakluczMnie.Data
{
    public class Riddle
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public required string Url { get; set; }
        public required List<AspNetUserRiddle> Users { get; set; }
    }
}
