namespace AgencyApis.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Plan { get; set; } = string.Empty; // Enterprise, Pro, Standard
        public string Status { get; set; } = string.Empty; // Active, Pending, Paused, Completed
        public decimal Spend { get; set; }
        public string LastActivity { get; set; } = string.Empty;
        public string? ContactPerson { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Industry { get; set; }
        public DateTime? StartDate { get; set; }
    }
}