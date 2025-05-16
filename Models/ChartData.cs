namespace AgencyApi.Models
{
    public class ChartData
    {
        public List<string> Labels { get; set; } = new List<string>();
        public List<Dataset> Datasets { get; set; } = new List<Dataset>();
    }

    public class Dataset
    {
        public string? Label { get; set; }
        public List<object> Data { get; set; } = new List<object>();
        public string? BorderColor { get; set; }
        public string? BackgroundColor { get; set; }
        public double? Tension { get; set; }
        public int? BorderWidth { get; set; }
        public int? PointRadius { get; set; }
        public int? PointHoverRadius { get; set; }
        public List<string>? BackgroundColors { get; set; }
    }
}