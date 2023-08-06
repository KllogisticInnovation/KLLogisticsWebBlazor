namespace KLLogisticsWebBlazor.Models
{
    public class Userapps
    {
        public string? Userid { get; set; }
    }
    public class GetUsername
    {
        public string? Username { get; set; }
    }
    public class GetLogin
    {
        public string? Userid { get; set; }
        //public string Username { get; set;}
        //public string Facility { get; set;}
        public string? Password { get; set; }
    }
    public class Top10user
    {
        public string? Userid { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }

    }
}
