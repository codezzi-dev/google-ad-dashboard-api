namespace AgencyApi.Models.Client
{
    public class Update
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty; // campaign, performance, action, info
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Author { get; set; } = string.Empty;
        public string? Action { get; set; }
        public int? RelatedCampaignId { get; set; }
    }
}