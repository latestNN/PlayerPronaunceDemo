namespace PlayerPronaunceDemo.Entities
{
    public class FootballTeam
    {
        public int FootballTeamId { get; set; }

        public string Name { get; set; }

        public string? ImageUrl { get; set; }

        public string Origin { get; set; }

        public ICollection<FootbalPlayer> Players { get; set; }
    }
}
