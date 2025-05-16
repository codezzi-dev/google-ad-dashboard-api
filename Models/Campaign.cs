namespace AgencyApi.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Client { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // Active, Pending, Paused, Completed
        public decimal Budget { get; set; }
        public Performance Performance { get; set; } = new Performance();
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? AdPlatform { get; set; }
        public string? Manager { get; set; }
        public string? Objective { get; set; }
        public string? TargetAudience { get; set; }
    }

    public class Performance
    {
        public decimal Value { get; set; }
        public string Trend { get; set; } = string.Empty; // up, down, neutral
    }
}