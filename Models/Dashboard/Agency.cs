// Models/Dashboard/Agency.cs
namespace AgencyApi.Models.Dashboard
{
    public class Agency
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Revenue { get; set; }
        public int Clients { get; set; }
        public int Growth { get; set; }
    }
}