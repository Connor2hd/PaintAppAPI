namespace PaintAppAPI.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DateCreated { get; set; }
    }
}
