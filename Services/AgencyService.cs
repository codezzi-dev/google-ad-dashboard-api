using AgencyApi.Models;
using AgencyApis.Models;
using Task = System.Threading.Tasks.Task;

namespace AgencyApi.Services
{
    public class AgencyService : IAgencyService
    {
        public async Task<List<MetricCard>> GetAgencyMetricsAsync()
        {
            // In a real app, this would fetch data from a database
            // For now, we'll mock the data similar to the Angular service
            
            // Calculate whether the trends are up or down based on current and previous data
            // This is just a sample implementation
            var clientCount = await GetClientsAsync();
            var activeClientCount = clientCount.Count(c => c.Status == "Active");
            var previousMonthActiveClients = activeClientCount - 4; // Assuming 4 new clients this month
            var clientTrendPercentage = CalculateTrendPercentage(activeClientCount, previousMonthActiveClients);
            
            var campaigns = await GetCampaignsAsync();
            var activeCampaigns = campaigns.Count(c => c.Status == "Active");
            var previousMonthActiveCampaigns = activeCampaigns - 5; // Assuming 5 new campaigns this month
            var campaignTrendPercentage = CalculateTrendPercentage(activeCampaigns, previousMonthActiveCampaigns);
            
            // Revenue data could be calculated from actual business logic
            var currentMonthRevenue = 158720m;
            var previousMonthRevenue = 141570m; // Example previous month revenue
            var revenueTrendPercentage = CalculateTrendPercentage(currentMonthRevenue, previousMonthRevenue);
            
            // Retention calculation
            var retentionRate = 94m; // This would be calculated based on actual client data
            
            return new List<MetricCard>
            {
                new MetricCard
                {
                    Title = "Total Clients",
                    Value = activeClientCount.ToString(),
                    Subvalue = "4 new this month",
                    Icon = "groups",
                    Color = "#4f46e5",
                    Trend = new Trend { Type = clientTrendPercentage > 0 ? "up" : "down", Value = $"{Math.Abs(clientTrendPercentage):0.0}%" }
                },
                new MetricCard
                {
                    Title = "Active Campaigns",
                    Value = activeCampaigns.ToString(),
                    Subvalue = $"Across {activeClientCount} clients",
                    Icon = "campaign",
                    Color = "#10b981",
                    Trend = new Trend { Type = campaignTrendPercentage > 0 ? "up" : "down", Value = $"{Math.Abs(campaignTrendPercentage):0.0}%" }
                },
                new MetricCard
                {
                    Title = "Monthly Revenue",
                    Value = $"${currentMonthRevenue:N0}",
                    Subvalue = "$28.4k commissions",
                    Icon = "attach_money",
                    Color = "#f59e0b",
                    Trend = new Trend { Type = revenueTrendPercentage > 0 ? "up" : "down", Value = $"{Math.Abs(revenueTrendPercentage):0.0}%" }
                },
                new MetricCard
                {
                    Title = "Client Retention",
                    Value = $"{retentionRate}%",
                    Subvalue = "2 clients churned YTD",
                    Icon = "psychology",
                    Color = "#06b6d4"
                }
            };
        }

        private double CalculateTrendPercentage(decimal current, decimal previous)
        {
            if (previous == 0)
                return 100;
            
            return (double)((current - previous) / previous * 100);
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
                        Label = "Total Revenue",
                        Data = new List<object> { 125000, 138000, 142500, 149000, 156000, 158720, 165000 },
                        BorderColor = "#4f46e5",
                        BackgroundColor = "rgba(79, 70, 229, 0.1)",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 3,
                        PointHoverRadius = 8
                    },
                    new Dataset
                    {
                        Label = "Ad Management",
                        Data = new List<object> { 92000, 102000, 105000, 110000, 115000, 118000, 122000 },
                        BorderColor = "#10b981",
                        BackgroundColor = "rgba(16, 185, 129, 0.1)",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 3,
                        PointHoverRadius = 5
                    },
                    new Dataset
                    {
                        Label = "Commissions",
                        Data = new List<object> { 22000, 24500, 25000, 26300, 27800, 28400, 29500 },
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

        public Task<ChartData> GetCampaignPerformanceDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "CTR (%)",
                        Data = new List<object> { 3.2, 3.4, 3.3, 3.6, 3.9, 4.1, 4.2 },
                        BorderColor = "#4f46e5",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 2
                    },
                    new Dataset
                    {
                        Label = "Conversion Rate (%)",
                        Data = new List<object> { 2.1, 2.3, 2.2, 2.5, 2.7, 2.9, 3.1 },
                        BorderColor = "#10b981",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 2
                    },
                    new Dataset
                    {
                        Label = "Cost Per Acquisition ($)",
                        Data = new List<object> { 24.2, 23.5, 24.0, 22.8, 21.7, 20.9, 20.1 },
                        BorderColor = "#f59e0b",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 2
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<ChartData> GetClientGrowthDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "New Clients",
                        Data = new List<object> { 3, 2, 2, 4, 3, 4, 2 },
                        BackgroundColor = "#4f46e5"
                    },
                    new Dataset
                    {
                        Label = "Churned Clients",
                        Data = new List<object> { 1, 0, 1, 0, 0, 1, 0 },
                        BackgroundColor = "#ef4444"
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<ChartData> GetAdSpendDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Tech Solutions Inc", "GlobalRetail", "NexGen Healthcare", "Urban Apparel", "FoodDelivery Plus", "Other Clients" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Data = new List<object> { 22, 18, 15, 12, 9, 24 },
                        BackgroundColors = new List<string>
                        {
                            "#4f46e5",
                            "#06b6d4",
                            "#10b981",
                            "#f59e0b",
                            "#ef4444",
                            "#8b5cf6"
                        },
                        BorderWidth = 1
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<List<Client>> GetClientsAsync()
        {
            var clients = new List<Client>
            {
                new Client { Id = 1, Name = "Tech Solutions Inc", Plan = "Enterprise", Status = "Active", Spend = 18500, LastActivity = "2 hours ago" },
                new Client { Id = 2, Name = "GlobalRetail", Plan = "Pro", Status = "Active", Spend = 15200, LastActivity = "5 hours ago" },
                new Client { Id = 3, Name = "NexGen Healthcare", Plan = "Enterprise", Status = "Active", Spend = 12800, LastActivity = "1 day ago" },
                new Client { Id = 4, Name = "Urban Apparel", Plan = "Pro", Status = "Active", Spend = 9700, LastActivity = "2 days ago" },
                new Client { Id = 5, Name = "FoodDelivery Plus", Plan = "Standard", Status = "Paused", Spend = 8400, LastActivity = "3 days ago" },
                new Client { Id = 6, Name = "EcoSmart Solutions", Plan = "Standard", Status = "Pending", Spend = 0, LastActivity = "Never" }
            };

            return Task.FromResult(clients);
        }

        public Task<List<Campaign>> GetCampaignsAsync()
        {
            var campaigns = new List<Campaign>
            {
                new Campaign
                {
                    Id = 1,
                    Name = "Summer Tech Promo 2025",
                    Client = "Tech Solutions Inc",
                    Status = "Active",
                    Budget = 12500,
                    Performance = new Performance { Value = 128, Trend = "up" },
                    StartDate = new DateTime(2025, 5, 1)
                },
                new Campaign
                {
                    Id = 2,
                    Name = "GlobalRetail Spring Collection",
                    Client = "GlobalRetail",
                    Status = "Active",
                    Budget = 9800,
                    Performance = new Performance { Value = 112, Trend = "up" },
                    StartDate = new DateTime(2025, 4, 15)
                },
                new Campaign
                {
                    Id = 3,
                    Name = "Healthcare Awareness Drive",
                    Client = "NexGen Healthcare",
                    Status = "Active",
                    Budget = 7500,
                    Performance = new Performance { Value = 105, Trend = "neutral" },
                    StartDate = new DateTime(2025, 3, 10)
                },
                new Campaign
                {
                    Id = 4,
                    Name = "Urban Summer Fashion",
                    Client = "Urban Apparel",
                    Status = "Pending",
                    Budget = 6200,
                    Performance = new Performance { Value = 0, Trend = "neutral" },
                    StartDate = new DateTime(2025, 5, 20)
                },
                new Campaign
                {
                    Id = 5,
                    Name = "Food Delivery App Promotion",
                    Client = "FoodDelivery Plus",
                    Status = "Paused",
                    Budget = 5400,
                    Performance = new Performance { Value = 92, Trend = "down" },
                    StartDate = new DateTime(2025, 2, 15)
                }
            };

            return Task.FromResult(campaigns);
        }

        public Task<List<TeamMember>> GetTeamMembersAsync()
        {
            var teamMembers = new List<TeamMember>
            {
                new TeamMember
                {
                    Id = 1,
                    Name = "Sarah Johnson",
                    Role = "Senior Account Manager",
                    Email = "sarah.j@agency.com",
                    ClientsManaged = 8,
                    CampaignsActive = 18,
                    AdSpend = 42.5m
                },
                new TeamMember
                {
                    Id = 2,
                    Name = "Michael Chen",
                    Role = "Campaign Specialist",
                    Email = "michael.c@agency.com",
                    ClientsManaged = 6,
                    CampaignsActive = 14,
                    AdSpend = 32.8m
                },
                new TeamMember
                {
                    Id = 3,
                    Name = "Emily Rodriguez",
                    Role = "Client Success Manager",
                    Email = "emily.r@agency.com",
                    ClientsManaged = 10,
                    CampaignsActive = 22,
                    AdSpend = 58.3m
                },
                new TeamMember
                {
                    Id = 4,
                    Name = "David Kim",
                    Role = "Ad Operations Specialist",
                    Email = "david.k@agency.com",
                    ClientsManaged = 8,
                    CampaignsActive = 16,
                    AdSpend = 38.4m
                }
            };

            return Task.FromResult(teamMembers);
        }

        public Task<List<Alert>> GetAlertsAsync()
        {
            var alerts = new List<Alert>
            {
                new Alert { Id = 1, Type = "warning", Message = "Tech Solutions Inc campaigns approaching budget limit", Time = "2h ago" },
                new Alert { Id = 2, Type = "danger", Message = "FoodDelivery Plus campaign performance below target", Time = "4h ago" },
                new Alert { Id = 3, Type = "info", Message = "New client onboarding: EcoSmart Solutions", Time = "6h ago" },
                new Alert { Id = 4, Type = "success", Message = "GlobalRetail campaign exceeded performance targets", Time = "12h ago" }
            };

            return Task.FromResult(alerts);
        }
    }
}