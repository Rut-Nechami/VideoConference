namespace VideoConference.Models
{
    public class Users
    {
        public int userId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Jobs Job { get; set; }

        public Users(string name, string email, Jobs job, Sides side, int userId)
        {
            Name = name;
            Email = email;
            Job = job;
            Side = side;
            this.userId = userId;
        }
    }
}
