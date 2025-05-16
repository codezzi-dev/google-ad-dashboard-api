namespace AgencyApi.Models
{
    public class Alert
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty; // warning, danger, info, success
        public string Message { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public bool? Read { get; set; }
    }
}