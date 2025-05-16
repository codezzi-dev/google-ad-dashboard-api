namespace AgencyApi.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int ClientsManaged { get; set; }
        public int CampaignsActive { get; set; }
        public decimal AdSpend { get; set; }
        public DateTime? JoinDate { get; set; }
        public decimal? PerformanceRating { get; set; }
        public List<string>? Skills { get; set; }
        public bool? IsOnline { get; set; }
        public string? LastSeen { get; set; }
    }
}