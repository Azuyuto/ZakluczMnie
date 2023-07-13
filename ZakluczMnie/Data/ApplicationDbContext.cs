using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ZakluczMnie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Riddle> Riddles { get; set; }
        public virtual DbSet<AspNetUserRiddle> AspNetUserRiddles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AspNetUserRiddle>(entity =>
            {
                entity.HasKey(e => new { e.AspNetUserId, e.RiddleId });

                entity.HasOne(d => d.AspNetUser)
                    .WithMany(p => p.Riddles)
                    .HasForeignKey(d => d.AspNetUserId)
                    .HasConstraintName("FK_AspNetUserRiddle_User");

                entity.HasOne(d => d.Riddle)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RiddleId)
                    .HasConstraintName("FK_AspNetUserRiddle_Riddle");
            });

            modelBuilder.Entity<Riddle>().HasData(
                new Riddle
                {
                    Id = Guid.NewGuid(),
                    Number = 1,
                    Url = "Start",
                    Users = new List<AspNetUserRiddle>()
                }
            );

            modelBuilder.Entity<Riddle>().HasData(
                new Riddle
                {
                    Id = Guid.NewGuid(),
                    Number = 2,
                    Url = "Nic",
                    Users = new List<AspNetUserRiddle>()
                }
            );

            modelBuilder.Entity<Riddle>().HasData(
                new Riddle
                {
                    Id = Guid.NewGuid(),
                    Number = 3,
                    Url = "Orzel",
                    Users = new List<AspNetUserRiddle>()
                }
            );

            modelBuilder.Entity<Riddle>().HasData(
                new Riddle
                {
                    Id = Guid.NewGuid(),
                    Number = 4,
                    Url = "StrusAfrykanski",
                    Users = new List<AspNetUserRiddle>()
                }
            );

            modelBuilder.Entity<Riddle>().HasData(
                new Riddle
                {
                    Id = Guid.NewGuid(),
                    Number = 5,
                    Url = "Bajka",
                    Users = new List<AspNetUserRiddle>()
                }
            );

            modelBuilder.Entity<Riddle>().HasData(
                new Riddle
                {
                    Id = Guid.NewGuid(),
                    Number = 6,
                    Url = "Szpaku",
                    Users = new List<AspNetUserRiddle>()
                }
            );
        }
    }
}