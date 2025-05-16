namespace AgencyApi.Models
{
    public class MetricCard
    {
        public string Title { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string Subvalue { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public Trend? Trend { get; set; }
    }

    public class Trend
    {
        public string Type { get; set; } = string.Empty; // up, down, neutral
        public string Value { get; set; } = string.Empty;
    }
}