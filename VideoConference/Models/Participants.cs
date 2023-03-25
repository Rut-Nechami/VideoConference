namespace VideoConference.Models
{
    public class Participants
    {
        public Users User { get; set; }

        public int UserId { get; set; }

        public bool IsCameraOn { get; set; }

        public bool IsMute { get; set; }

        public Sides Side { get; set; }
    }
}
