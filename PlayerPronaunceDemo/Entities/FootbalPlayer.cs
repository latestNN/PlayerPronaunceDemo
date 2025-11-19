using System.ComponentModel.DataAnnotations;

namespace PlayerPronaunceDemo.Entities
{
    public class FootbalPlayer
    {
        public int FootbalPlayerId { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Nation { get; set; }

        public string? NationFlagImageUrl { get; set; }

        public int FootballTeamId { get; set; }

        public FootballTeam footballTeam { get; set; }

        public ICollection<Sound> Sounds { get; set; }
    }
}
