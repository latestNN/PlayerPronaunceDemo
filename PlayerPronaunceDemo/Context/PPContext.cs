using Microsoft.EntityFrameworkCore;
using PlayerPronaunceDemo.Entities;

namespace PlayerPronaunceDemo.Context
{
    public class PPContext : DbContext
    {
        public PPContext(DbContextOptions<PPContext> options)
        : base(options)
        {
        }

        public DbSet<FootbalPlayer> FootbalPlayers { get; set; }
        public DbSet<FootballTeam> FootballTeams { get; set; }

        public DbSet<Sound> Sounds { get; set; }
    }
}
