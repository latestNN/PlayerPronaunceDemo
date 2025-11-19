namespace PlayerPronaunceDemo.Entities
{
    public class Sound
    {
        public int SoundId { get; set; }

        public string? CasterName { get; set; }
        public string? CasterImageUrl { get; set; }
        public string? CasterNationImageUrl { get; set; }
        public string? SoundPath { get; set; }
        public bool IsEpic { get; set; } = false;

        public string? SoundNation { get; set; }



        public int FootballPlayerId { get; set; }

        public FootbalPlayer footballPlayer { get; set; }



    }
}
