namespace VideoConference.Models
{
    public class Conferences
    {
        public int ConferenceId { get; set; }
        public IEnumerable<Participants> Participants { get; set; }

        public DateTime ConferenceDate { get; set; }

        public long ConferenceDuration { get; set; }
    }
}
