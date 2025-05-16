

// Services/ClientService.cs
using AgencyApi.Models;
using AgencyApi.Models.Client;
using Task = System.Threading.Tasks.Task;
using Campaign = AgencyApi.Models.Client.ClientCampaign;

namespace AgencyApi.Services
{
    public class ClientService : IClientService
    {
        public Task<AdAccount> GetClientDetailsAsync()
        {
            var client = new AdAccount
            {
                Id = 1,
                Name = "Tech Solutions Inc",
                Plan = "Enterprise",
                Status = "Active",
                AccountManager = "Sarah Johnson",
                NextReview = new DateTime(2025, 5, 20),
                ContactEmail = "john.smith@techsolutions.com",
                ContactPhone = "(555) 123-4567",
                Industry = "Technology",
                StartDate = new DateTime(2024, 1, 15)
            };

            return Task.FromResult(client);
        }

        public Task<List<MetricCard>> GetPerformanceMetricsAsync()
        {
            var metrics = new List<MetricCard>
            {
                new MetricCard
                {
                    Title = "Total Clicks",
                    Value = "42,854",
                    Subvalue = "18.5% increase vs. last period",
                    Icon = "touch_app",
                    Color = "#4f46e5",
                    Trend = new Trend { Type = "up", Value = "18.5%" }
                },
                new MetricCard
                {
                    Title = "Conversions",
                    Value = "1,286",
                    Subvalue = "21.3% increase vs. last period",
                    Icon = "check_circle",
                    Color = "#10b981",
                    Trend = new Trend { Type = "up", Value = "21.3%" }
                },
                new MetricCard
                {
                    Title = "Avg. Cost/Conversion",
                    Value = "$28.42",
                    Subvalue = "5.6% decrease vs. last period",
                    Icon = "attach_money",
                    Color = "#f59e0b",
                    Trend = new Trend { Type = "up", Value = "5.6%" }
                },
                new MetricCard
                {
                    Title = "Return on Ad Spend",
                    Value = "380%",
                    Subvalue = "15.2% increase vs. last period",
                    Icon = "trending_up",
                    Color = "#06b6d4",
                    Trend = new Trend { Type = "up", Value = "15.2%" }
                }
            };

            return Task.FromResult(metrics);
        }

        public Task<ChartData> GetPerformanceTrendsDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "May 1", "May 4", "May 7", "May 10", "May 13", "May 16", "May 19", "May 22", "May 25", "May 28" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "Clicks",
                        Data = new List<object> { 2840, 3120, 2950, 3450, 4210, 4030, 4520, 4680, 4850, 5040 },
                        BorderColor = "#4f46e5",
                        BackgroundColor = "rgba(79, 70, 229, 0.1)",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 3,
                        PointHoverRadius = 8
                    },
                    new Dataset
                    {
                        Label = "Conversions",
                        Data = new List<object> { 86, 94, 88, 103, 126, 121, 136, 140, 145, 151 },
                        BorderColor = "#10b981",
                        BackgroundColor = "rgba(16, 185, 129, 0.1)",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 3,
                        PointHoverRadius = 5
                    },
                    new Dataset
                    {
                        Label = "Impressions (thousands)",
                        Data = new List<object> { 28.4, 31.2, 29.5, 34.5, 42.1, 40.3, 45.2, 46.8, 48.5, 50.4 },
                        BorderColor = "#f59e0b",
                        BackgroundColor = "rgba(245, 158, 11, 0.1)",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 3,
                        PointHoverRadius = 5
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<ChartData> GetBudgetDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Apr 25-May 1", "May 2-8", "May 9-15", "May 16-22", "May 23-29" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "Planned Budget",
                        Data = new List<object> { 3000, 3000, 3500, 3000, 2500 },
                        BackgroundColor = "rgba(79, 70, 229, 0.2)",
                        BorderColor = "rgba(79, 70, 229, 1)",
                        BorderWidth = 1
                    },
                    new Dataset
                    {
                        Label = "Actual Spend",
                        Data = new List<object> { 2850, 3120, 3580, 3245, 2200 },
                        BackgroundColor = "rgba(16, 185, 129, 0.2)",
                        BorderColor = "rgba(16, 185, 129, 1)",
                        BorderWidth = 1
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<ChartData> GetConversionDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Search", "Display", "Social", "Email", "Referral" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Data = new List<object> { 45, 25, 20, 7, 3 },
                        BackgroundColors = new List<string>
                        {
                            "#4f46e5",
                            "#06b6d4",
                            "#10b981",
                            "#f59e0b",
                            "#ef4444"
                        },
                        BorderWidth = 1
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<ChartData> GetCampaignPerformanceDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Campaign 1", "Campaign 2", "Campaign 3", "Campaign 4" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "ROAS",
                        Data = new List<object> { 4.2, 3.8, 2.9, 5.1 },
                        BackgroundColors = new List<string>
                        {
                            "rgba(79, 70, 229, 0.7)",
                            "rgba(6, 182, 212, 0.7)",
                            "rgba(16, 185, 129, 0.7)",
                            "rgba(245, 158, 11, 0.7)"
                        },
                        BorderWidth = 0
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<List<Campaign>> GetActiveCampaignsAsync()
        {
            var campaigns = new List<Campaign>
            {
                new Campaign
                {
                    Id = 1,
                    Name = "Summer Tech Promo 2025",
                    Status = "Active",
                    StartDate = new DateTime(2025, 5, 1),
                    EndDate = new DateTime(2025, 6, 30),
                    Budget = 12500,
                    BudgetSpent = 0.42m,
                    Impressions = 325000,
                    Clicks = 18750,
                    ClicksChange = 0.12m,
                    Conversions = 625,
                    ConversionsChange = 0.18m,
                    CostPerConversion = 18.65m,
                    CostPerConversionChange = -0.08m
                },
                new Campaign
                {
                    Id = 2,
                    Name = "Enterprise Solutions Campaign",
                    Status = "Active",
                    StartDate = new DateTime(2025, 4, 15),
                    EndDate = new DateTime(2025, 6, 15),
                    Budget = 18000,
                    BudgetSpent = 0.65m,
                    Impressions = 420000,
                    Clicks = 14800,
                    ClicksChange = 0.08m,
                    Conversions = 420,
                    ConversionsChange = 0.05m,
                    CostPerConversion = 27.90m,
                    CostPerConversionChange = -0.03m
                },
                new Campaign
                {
                    Id = 3,
                    Name = "Developer Tools Awareness",
                    Status = "Paused",
                    StartDate = new DateTime(2025, 3, 15),
                    EndDate = new DateTime(2025, 6, 15),
                    Budget = 8500,
                    BudgetSpent = 0.48m,
                    Impressions = 185000,
                    Clicks = 7350,
                    ClicksChange = -0.04m,
                    Conversions = 180,
                    ConversionsChange = -0.12m,
                    CostPerConversion = 32.45m,
                    CostPerConversionChange = 0.14m
                },
                new Campaign
                {
                    Id = 4,
                    Name = "Cloud Services Promotion",
                    Status = "Pending",
                    StartDate = new DateTime(2025, 6, 1),
                    EndDate = new DateTime(2025, 8, 31),
                    Budget = 15000,
                    BudgetSpent = 0,
                    Impressions = 0,
                    Clicks = 0,
                    ClicksChange = 0,
                    Conversions = 0,
                    ConversionsChange = 0,
                    CostPerConversion = 0,
                    CostPerConversionChange = 0
                }
            };

            return Task.FromResult(campaigns);
        }

        public Task<List<AdCreative>> GetCreativesAsync()
        {
            var creatives = new List<AdCreative>
            {
                new AdCreative
                {
                    Id = 1,
                    Name = "Summer Tech Promotion - Banner 1",
                    Description = "Main banner for the Summer Promotion featuring cloud services.",
                    Status = "Active",
                    Campaign = "Summer Tech Promo 2025",
                    CreatedDate = new DateTime(2025, 4, 20),
                    PreviewUrl = "assets/images/ad-creative-1.jpg",
                    Headline = "Transform Your Business with Cloud Technology",
                    CallToAction = "Get Started Today"
                },
                new AdCreative
                {
                    Id = 2,
                    Name = "Enterprise Solutions - Video Ad",
                    Description = "Video showcase of enterprise solution benefits with customer testimonials.",
                    Status = "Active",
                    Campaign = "Enterprise Solutions Campaign",
                    CreatedDate = new DateTime(2025, 4, 10),
                    PreviewUrl = "assets/images/ad-creative-2.jpg",
                    Format = "Video",
                    CallToAction = "Schedule a Demo"
                },
                new AdCreative
                {
                    Id = 3,
                    Name = "Developer Tools - Carousel Ad",
                    Description = "Carousel showcasing key features of the developer toolkit.",
                    Status = "Pending",
                    Campaign = "Developer Tools Awareness",
                    CreatedDate = new DateTime(2025, 5, 12),
                    PreviewUrl = "assets/images/ad-creative-3.jpg",
                    Format = "Carousel",
                    CallToAction = "Explore Features"
                },
                new AdCreative
                {
                    Id = 4,
                    Name = "Cloud Services - Display Ad",
                    Description = "Display ad highlighting cost savings with cloud services.",
                    Status = "Pending",
                    Campaign = "Cloud Services Promotion",
                    CreatedDate = new DateTime(2025, 5, 15),
                    PreviewUrl = "assets/images/ad-creative-4.jpg",
                    Headline = "Reduce IT Costs by 40% with Our Cloud Solutions",
                    CallToAction = "Calculate Savings"
                },
                new AdCreative
                {
                    Id = 5,
                    Name = "Tech Solutions Mobile App - Banner",
                    Description = "Banner promoting the new mobile app for accessing services on the go.",
                    Status = "Pending",
                    Campaign = "Summer Tech Promo 2025",
                    CreatedDate = new DateTime(2025, 5, 18),
                    PreviewUrl = "assets/images/ad-creative-5.jpg",
                    Headline = "Take Your Business Anywhere with Our New Mobile App",
                    CallToAction = "Download Now"
                }
            };

            return Task.FromResult(creatives);
        }

        public Task<List<Update>> GetUpdatesAsync()
        {
            var updates = new List<Update>
            {
                new Update
                {
                    Id = 1,
                    Type = "campaign",
                    Title = "New Campaign Proposal",
                    Message = "We've prepared a proposal for a new \"Cloud Services Promotion\" campaign targeting enterprise customers for Q3.",
                    Date = new DateTime(2025, 5, 14),
                    Author = "Sarah Johnson",
                    Action = "Review Proposal",
                    RelatedCampaignId = 4
                },
                new Update
                {
                    Id = 2,
                    Type = "performance",
                    Title = "Performance Improvement",
                    Message = "Your \"Summer Tech Promo\" campaign is performing 23% above industry benchmarks for click-through rates.",
                    Date = new DateTime(2025, 5, 12),
                    Author = "Michael Chen",
                    RelatedCampaignId = 1
                },
                new Update
                {
                    Id = 3,
                    Type = "action",
                    Title = "Creative Approval Needed",
                    Message = "Three new ad creatives require your approval before they can go live.",
                    Date = new DateTime(2025, 5, 10),
                    Author = "Emily Rodriguez",
                    Action = "Review Creatives"
                },
                new Update
                {
                    Id = 4,
                    Type = "info",
                    Title = "Monthly Report Available",
                    Message = "Your April 2025 performance report is now available for download.",
                    Date = new DateTime(2025, 5, 5),
                    Author = "David Kim",
                    Action = "View Report"
                }
            };

            return Task.FromResult(updates);
        }

        public Task<List<Report>> GetReportsAsync()
        {
            var reports = new List<Report>
            {
                new Report
                {
                    Id = 1,
                    Name = "April 2025 Performance Report",
                    Description = "Complete breakdown of campaign performance for April 2025.",
                    Date = new DateTime(2025, 5, 5),
                    Format = "PDF",
                    FileSize = "3.2 MB",
                    PeriodCovered = new PeriodCovered
                    {
                        Start = new DateTime(2025, 4, 1),
                        End = new DateTime(2025, 4, 30)
                    }
                },
                new Report
                {
                    Id = 2,
                    Name = "Q1 2025 Strategic Analysis",
                    Description = "Comprehensive analysis of Q1 performance and recommendations for Q2.",
                    Date = new DateTime(2025, 4, 15),
                    Format = "PDF",
                    FileSize = "5.8 MB",
                    PeriodCovered = new PeriodCovered
                    {
                        Start = new DateTime(2025, 1, 1),
                        End = new DateTime(2025, 3, 31)
                    }
                },
                new Report
                {
                    Id = 3,
                    Name = "Campaign ROI Report - Enterprise Solutions",
                    Description = "Detailed ROI analysis for the Enterprise Solutions campaign.",
                    Date = new DateTime(2025, 5, 10),
                    Format = "XLSX",
                    FileSize = "1.4 MB",
                    PeriodCovered = new PeriodCovered
                    {
                        Start = new DateTime(2025, 4, 15),
                        End = new DateTime(2025, 5, 10)
                    }
                },
                new Report
                {
                    Id = 4,
                    Name = "Audience Insights Report",
                    Description = "Analysis of audience demographics and behavior across all campaigns.",
                    Date = new DateTime(2025, 4, 28),
                    Format = "PDF",
                    FileSize = "2.7 MB"
                }
            };

            return Task.FromResult(reports);
        }

        public Task<List<Alert>> GetAlertsAsync()
        {
            var alerts = new List<Alert>
            {
                new Alert { Id = 1, Type = "info", Message = "Your monthly performance review is scheduled for May 20", Time = "2h ago" },
                new Alert { Id = 2, Type = "warning", Message = "Developer Tools campaign performance below target by 12%", Time = "5h ago" },
                new Alert { Id = 3, Type = "success", Message = "Summer Tech Promo campaign exceeding conversion targets by 18%", Time = "1d ago" },
                new Alert { Id = 4, Type = "info", Message = "New ad creatives ready for your review", Time = "1d ago" }
            };

            return Task.FromResult(alerts);
        }
    }
}