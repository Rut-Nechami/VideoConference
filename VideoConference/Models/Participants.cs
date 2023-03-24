namespace VideoConference.Models
{
    public class Participants
    {
        public int userId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Jobs Job { get; set; }

        public Sides Side { get; set; }
        public Participants(string name, string email, Jobs job, Sides side, int userId)
        {
            Name = name;
            Email = email;
            Job = job;
            Side = side;
            this.userId = userId;   
        }
    }
}
