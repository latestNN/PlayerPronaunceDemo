using Microsoft.EntityFrameworkCore;
using PlayerPronaunceDemo.Entities;

namespace PlayerPronaunceDemo.Context
{
    public class PPContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ALI-LAPTOP\\SQLEXPRESS;initial Catalog=PlayerPronaunceV1;Integrated Security=true; trust server certificate=true");
        }

        public DbSet<FootbalPlayer> FootbalPlayers { get; set; }
        public DbSet<FootballTeam> FootballTeams { get; set; }

        public DbSet<Sound> Sounds { get; set; }
    }
}
