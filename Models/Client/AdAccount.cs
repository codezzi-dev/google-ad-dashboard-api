namespace AgencyApi.Models.Client
{
    public class AdAccount
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Plan { get; set; } = string.Empty; // Enterprise, Pro, Standard
        public string Status { get; set; } = string.Empty; // Active, Paused
        public string AccountManager { get; set; } = string.Empty;
        public DateTime NextReview { get; set; }
        public BillingInfo? BillingInfo { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public string? Industry { get; set; }
        public DateTime? StartDate { get; set; }
        public string? Logo { get; set; }
    }

    public class BillingInfo
    {
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}