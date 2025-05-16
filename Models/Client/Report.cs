namespace AgencyApi.Models.Client
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Format { get; set; } = string.Empty; // PDF, CSV, XLSX
        public string? FileSize { get; set; }
        public PeriodCovered? PeriodCovered { get; set; }
    }

    public class PeriodCovered
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}