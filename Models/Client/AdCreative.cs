namespace AgencyApi.Models.Client
{
    public class AdCreative
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // Active, Pending, Rejected
        public string Campaign { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string PreviewUrl { get; set; } = string.Empty;
        public string? AdCopy { get; set; }
        public string? Headline { get; set; }
        public string? CallToAction { get; set; }
        public string? TargetUrl { get; set; }
        public string? Format { get; set; } // Image, Video, Carousel, Text
    }
}