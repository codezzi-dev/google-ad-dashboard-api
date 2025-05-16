// Services/IDashboardService.cs
using AgencyApi.Models;
using AgencyApi.Models.Dashboard;
using AgencyApis.Models;
using Task = System.Threading.Tasks.Task;

namespace AgencyApi.Services
{
    public class DashboardService : IDashboardService
    {
        public Task<List<MetricCard>> GetFinancialMetricsAsync()
        {
            var metrics = new List<MetricCard>
            {
                new MetricCard
                {
                    Title = "Total Ad Spent",
                    Value = "$348,500",
                    Subvalue = "Clients spent on ad",
                    Icon = "attach_money",
                    Color = "#4f46e5",
                    Trend = new Trend { Type = "up", Value = "4.5%" }
                },
                new MetricCard
                {
                    Title = "Commissions Earned",
                    Value = "$133,170",
                    Subvalue = "From agencies and clients",
                    Icon = "attach_money",
                    Color = "#10b981",
                    Trend = new Trend { Type = "up", Value = "3.2%" }
                },
                new MetricCard
                {
                    Title = "Payout To Agencies",
                    Value = "$78,920",
                    Subvalue = "$12,450 pending",
                    Icon = "business",
                    Color = "#06b6d4"
                },
                new MetricCard
                {
                    Title = "Agency Onboarding",
                    Value = "24",
                    Subvalue = "6 new this month",
                    Icon = "people",
                    Color = "#f59e0b",
                    Trend = new Trend { Type = "up", Value = "8.3%" }
                }
            };

            return Task.FromResult(metrics);
        }

        public Task<List<MetricCard>> GetCampaignMetricsAsync()
        {
            var metrics = new List<MetricCard>
            {
                new MetricCard
                {
                    Title = "Live Campaigns",
                    Value = "267",
                    Subvalue = "18 added this month",
                    Icon = "trending_up",
                    Color = "#4f46e5",
                    Trend = new Trend { Type = "up", Value = "7.2%" }
                },
                new MetricCard
                {
                    Title = "Total Ad Spend",
                    Value = "$1.24M",
                    Subvalue = "vs $1.2M planned",
                    Icon = "attach_money",
                    Color = "#f59e0b",
                    Trend = new Trend { Type = "up", Value = "3.3%" }
                },
                new MetricCard
                {
                    Title = "Avg. CTR",
                    Value = "3.8%",
                    Subvalue = "Industry avg: 2.1%",
                    Icon = "trending_up",
                    Color = "#10b981",
                    Trend = new Trend { Type = "up", Value = "0.7%" }
                }
            };

            return Task.FromResult(metrics);
        }

        public Task<ChartData> GetRevenueDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "Ad Spent",
                        Data = new List<object> { 42000, 48000, 46500, 52000, 58000, 64000, 68000 },
                        BorderColor = "#4f46e5",
                        BackgroundColor = "rgba(79, 70, 229, 0.1)",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 3,
                        PointHoverRadius = 8
                    },
                    new Dataset
                    {
                        Label = "Agency Commission",
                        Data = new List<object> { 15400, 16800, 16270, 18200, 20300, 22400, 23800 },
                        BorderColor = "#10b981",
                        BackgroundColor = "rgba(16, 185, 129, 0.1)",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 3,
                        PointHoverRadius = 5
                    },
                    new Dataset
                    {
                        Label = "PO Commission",
                        Data = new List<object> { 8400, 9600, 9300, 10400, 11600, 12800, 13600 },
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

        public Task<ChartData> GetQuarterlyDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "First", "Second", "Third", "Fourth" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Data = new List<object> { 10520, 12540, 9350, 15420 },
                        BackgroundColors = new List<string>
                        {
                            "#4f46e5",
                            "#06b6d4",
                            "#10b981",
                            "#f59e0b"
                        },
                        BorderWidth = 1
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<ChartData> GetPerformanceDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "CTR (%)",
                        Data = new List<object> { 2.8, 3.1, 2.9, 3.4, 3.6, 3.8, 4.1 },
                        BorderColor = "#4f46e5",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 2
                    },
                    new Dataset
                    {
                        Label = "Conv. Rate (%)",
                        Data = new List<object> { 3.2, 3.5, 3.1, 3.8, 4.0, 4.2, 4.5 },
                        BorderColor = "#10b981",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 2
                    },
                    new Dataset
                    {
                        Label = "CPC ($)",
                        Data = new List<object> { 1.2, 1.1, 1.3, 1.0, 0.9, 0.8, 0.75 },
                        BorderColor = "#06b6d4",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 2
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<ChartData> GetSubscriptionDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Enterprise", "Pro", "Standard" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Data = new List<object> { 35, 45, 20 },
                        BackgroundColors = new List<string>
                        {
                            "#4f46e5",
                            "#06b6d4",
                            "#10b981"
                        },
                        BorderWidth = 1
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<ChartData> GetCampaignSummaryDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "Campaign Spend",
                        Data = new List<object> { 42, 48, 46.5, 52, 58, 64, 68 },
                        BackgroundColor = "#4f46e5",
                        BorderWidth = 4 // Using borderWidth to represent borderRadius
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<List<Agency>> GetAgenciesAsync()
        {
            var agencies = new List<Agency>
            {
                new Agency { Id = 1, Name = "Digital Surge", Revenue = 120000, Clients = 24, Growth = 18 },
                new Agency { Id = 2, Name = "AdVantage", Revenue = 105000, Clients = 21, Growth = 12 },
                new Agency { Id = 3, Name = "MediaForce", Revenue = 98000, Clients = 18, Growth = 15 },
                new Agency { Id = 4, Name = "ClickMasters", Revenue = 87000, Clients = 16, Growth = 9 },
                new Agency { Id = 5, Name = "WebPros", Revenue = 76000, Clients = 14, Growth = 7 }
            };

            return Task.FromResult(agencies);
        }

        public Task<List<Client>> GetClientsAsync()
        {
            var clients = new List<Client>
            {
                new Client { Id = 1, Name = "Tech Solutions Inc", Spend = 18500, Plan = "Enterprise" },
                new Client { Id = 2, Name = "GlobalRetail", Spend = 15200, Plan = "Pro" },
                new Client { Id = 3, Name = "NexGen Healthcare", Spend = 12800, Plan = "Enterprise" },
                new Client { Id = 4, Name = "Urban Apparel", Spend = 9700, Plan = "Pro" },
                new Client { Id = 5, Name = "FoodDelivery Plus", Spend = 8400, Plan = "Standard" }
            };

            return Task.FromResult(clients);
        }

        public Task<List<Alert>> GetAlertsAsync()
        {
            var alerts = new List<Alert>
            {
                new Alert { Id = 1, Type = "warning", Message = "3 agency subscriptions expiring in 7 days", Time = "2h ago" },
                new Alert { Id = 2, Type = "danger", Message = "Failed payment for ClickMasters ($2,400)", Time = "4h ago" },
                new Alert { Id = 3, Type = "info", Message = "System maintenance scheduled for Sunday 2AM", Time = "6h ago" },
                new Alert { Id = 4, Type = "success", Message = "New agency onboarded: MarketingPros", Time = "12h ago" }
            };

            return Task.FromResult(alerts);
        }
    }
}