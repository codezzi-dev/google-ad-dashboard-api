namespace AgencyApi.Models.Client
{
    public class ClientCampaign  
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // Active, Paused, Pending, Completed, Draft
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal Budget { get; set; }
        public decimal BudgetSpent { get; set; }
        public int Impressions { get; set; }
        public int Clicks { get; set; }
        public decimal ClicksChange { get; set; }
        public int Conversions { get; set; }
        public decimal ConversionsChange { get; set; }
        public decimal CostPerConversion { get; set; }
        public decimal CostPerConversionChange { get; set; }
        public string? Objective { get; set; }
        public string? TargetAudience { get; set; }
        public List<string>? Platforms { get; set; }
        public string? AdType { get; set; }
    }
}