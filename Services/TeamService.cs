// Services/ITeamService.cs
using AgencyApi.Models;
using AgencyApis.Models;
using Task = System.Threading.Tasks.Task;


namespace AgencyApi.Services
{
    public class TeamService : ITeamService
    {
        public Task<TeamMember> GetCurrentUserAsync()
        {
            var user = new TeamMember
            {
                Id = 1,
                Name = "Sarah Johnson",
                Role = "Senior Account Manager",
                Email = "sarah.j@agency.com",
                ClientsManaged = 8,
                CampaignsActive = 18,
                AdSpend = 42.5m,
                PerformanceRating = 95,
                Skills = new List<string> { "Google Ads", "Facebook Ads", "Campaign Strategy", "Client Management" }
            };

            return Task.FromResult(user);
        }

        public Task<List<MetricCard>> GetPerformanceMetricsAsync()
        {
            var metrics = new List<MetricCard>
            {
                new MetricCard
                {
                    Title = "Performance Score",
                    Value = "95/100",
                    Subvalue = "Top 10% of team",
                    Icon = "analytics",
                    Color = "#4f46e5",
                    Trend = new Trend { Type = "up", Value = "3 pts" }
                },
                new MetricCard
                {
                    Title = "Campaign Success",
                    Value = "94%",
                    Subvalue = "17/18 campaigns on target",
                    Icon = "military_tech",
                    Color = "#10b981",
                    Trend = new Trend { Type = "up", Value = "2.3%" }
                },
                new MetricCard
                {
                    Title = "Client Satisfaction",
                    Value = "4.8/5",
                    Subvalue = "Based on client feedback",
                    Icon = "thumb_up",
                    Color = "#f59e0b",
                    Trend = new Trend { Type = "up", Value = "0.2 pts" }
                },
                new MetricCard
                {
                    Title = "Task Completion",
                    Value = "97%",
                    Subvalue = "36/37 tasks completed on time",
                    Icon = "check_circle",
                    Color = "#06b6d4",
                    Trend = new Trend { Type = "up", Value = "1.5%" }
                }
            };

            return Task.FromResult(metrics);
        }

        public Task<ChartData> GetPerformanceTrendsDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Week 1", "Week 2", "Week 3", "Week 4", "Week 5", "Week 6", "Week 7", "Week 8" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "Campaign Performance",
                        Data = new List<object> { 88, 89, 87, 92, 94, 93, 95, 94 },
                        BorderColor = "#4f46e5",
                        BackgroundColor = "rgba(79, 70, 229, 0.1)",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 3,
                        PointHoverRadius = 6
                    },
                    new Dataset
                    {
                        Label = "Client Satisfaction",
                        Data = new List<object> { 4.4, 4.5, 4.5, 4.6, 4.7, 4.8, 4.8, 4.8 },
                        BorderColor = "#10b981",
                        BackgroundColor = "rgba(16, 185, 129, 0.1)",
                        Tension = 0.3,
                        BorderWidth = 2,
                        PointRadius = 3,
                        PointHoverRadius = 5
                    },
                    new Dataset
                    {
                        Label = "Tasks Completed",
                        Data = new List<object> { 92, 94, 91, 95, 94, 96, 98, 97 },
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

        public Task<ChartData> GetClientDistributionDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Tech Solutions Inc", "GlobalRetail", "NexGen Healthcare", "Urban Apparel", "FoodDelivery Plus", "EcoSmart", "MediaCorp", "WebServices Pro" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Data = new List<object> { 22, 18, 15, 12, 9, 8, 8, 8 },
                        BackgroundColors = new List<string>
                        {
                            "#4f46e5",
                            "#06b6d4",
                            "#10b981",
                            "#f59e0b",
                            "#ef4444",
                            "#8b5cf6",
                            "#ec4899",
                            "#64748b"
                        },
                        BorderWidth = 1
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<ChartData> GetWeeklyActivityDataAsync()
        {
            var chartData = new ChartData
            {
                Labels = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" },
                Datasets = new List<Dataset>
                {
                    new Dataset
                    {
                        Label = "Tasks Completed",
                        Data = new List<object> { 5, 7, 6, 8, 4 },
                        BackgroundColor = "#4f46e5"
                    },
                    new Dataset
                    {
                        Label = "Meetings Attended",
                        Data = new List<object> { 3, 2, 4, 2, 2 },
                        BackgroundColor = "#06b6d4"
                    },
                    new Dataset
                    {
                        Label = "Client Interactions",
                        Data = new List<object> { 2, 3, 4, 3, 5 },
                        BackgroundColor = "#10b981"
                    }
                }
            };

            return Task.FromResult(chartData);
        }

        public Task<List<Client>> GetAssignedClientsAsync()
        {
            var clients = new List<Client>
            {
                new Client { Id = 1, Name = "Tech Solutions Inc", Plan = "Enterprise", Status = "Active", Spend = 18500, LastActivity = "2 hours ago" },
                new Client { Id = 2, Name = "GlobalRetail", Plan = "Pro", Status = "Active", Spend = 15200, LastActivity = "5 hours ago" },
                new Client { Id = 3, Name = "NexGen Healthcare", Plan = "Enterprise", Status = "Active", Spend = 12800, LastActivity = "1 day ago" },
                new Client { Id = 4, Name = "Urban Apparel", Plan = "Pro", Status = "Active", Spend = 9700, LastActivity = "2 days ago" },
                new Client { Id = 5, Name = "FoodDelivery Plus", Plan = "Standard", Status = "Paused", Spend = 8400, LastActivity = "3 days ago" },
                new Client { Id = 6, Name = "EcoSmart Solutions", Plan = "Standard", Status = "Pending", Spend = 0, LastActivity = "Never" },
                new Client { Id = 7, Name = "MediaCorp", Plan = "Pro", Status = "Active", Spend = 7800, LastActivity = "6 hours ago" },
                new Client { Id = 8, Name = "WebServices Pro", Plan = "Standard", Status = "Active", Spend = 6500, LastActivity = "1 day ago" }
            };

            return Task.FromResult(clients);
        }

        public Task<List<Campaign>> GetAssignedCampaignsAsync()
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
                },
                new Campaign
                {
                    Id = 6,
                    Name = "Eco-Friendly Products Launch",
                    Client = "EcoSmart Solutions",
                    Status = "Pending",
                    Budget = 4800,
                    Performance = new Performance { Value = 0, Trend = "neutral" },
                    StartDate = new DateTime(2025, 5, 25)
                },
                new Campaign
                {
                    Id = 7,
                    Name = "Media Subscription Drive",
                    Client = "MediaCorp",
                    Status = "Active",
                    Budget = 7200,
                    Performance = new Performance { Value = 118, Trend = "up" },
                    StartDate = new DateTime(2025, 4, 5)
                },
                new Campaign
                {
                    Id = 8,
                    Name = "Web Services Promo",
                    Client = "WebServices Pro",
                    Status = "Active",
                    Budget = 6100,
                    Performance = new Performance { Value = 108, Trend = "up" },
                    StartDate = new DateTime(2025, 4, 10)
                }
            };

            return Task.FromResult(campaigns);
        }

        public Task<List<Models.Task>> GetAssignedTasksAsync()
        {
            var tasks = new List<Models.Task>
            {
                new Models.Task
                {
                    Id = 1,
                    Title = "Create Q3 Strategy for Tech Solutions",
                    Description = "Develop comprehensive Q3 marketing strategy including budget allocations and campaign focus.",
                    DueDate = new DateTime(2025, 5, 18),
                    Priority = "High",
                    Progress = 65,
                    Client = "Tech Solutions Inc",
                    Tags = new List<string> { "Strategy", "Q3", "Planning" },
                    AssignedTo = 1,
                    IsOverdue = false
                },
                new Models.Task
                {
                    Id = 2,
                    Title = "GlobalRetail Campaign Launch",
                    Description = "Finalize creatives and targeting for the Summer Collection campaign launch.",
                    DueDate = new DateTime(2025, 5, 15),
                    Priority = "High",
                    Progress = 85,
                    Client = "GlobalRetail",
                    Tags = new List<string> { "Launch", "Creative", "Targeting" },
                    AssignedTo = 1,
                    IsOverdue = false
                },
                new Models.Task
                {
                    Id = 3,
                    Title = "NexGen Healthcare Performance Review",
                    Description = "Review Q2 campaign performance and prepare presentation for client meeting.",
                    DueDate = new DateTime(2025, 5, 12),
                    Priority = "Medium",
                    Progress = 40,
                    Client = "NexGen Healthcare",
                    Tags = new List<string> { "Review", "Analytics", "Presentation" },
                    AssignedTo = 1,
                    IsOverdue = true
                },
                new Models.Task
                {
                    Id = 4,
                    Title = "Urban Apparel Budget Adjustment",
                    Description = "Analyze current campaign performance and make budget adjustments to optimize results.",
                    DueDate = new DateTime(2025, 5, 20),
                    Priority = "Medium",
                    Progress = 30,
                    Client = "Urban Apparel",
                    Tags = new List<string> { "Budget", "Optimization" },
                    AssignedTo = 1,
                    IsOverdue = false
                },
                new Models.Task
                {
                    Id = 5,
                    Title = "FoodDelivery Plus Campaign Optimization",
                    Description = "Address decreasing performance by reviewing and optimizing ad creative and targeting.",
                    DueDate = new DateTime(2025, 5, 14),
                    Priority = "High",
                    Progress = 20,
                    Client = "FoodDelivery Plus",
                    Tags = new List<string> { "Optimization", "Performance", "Creative" },
                    AssignedTo = 1,
                    IsOverdue = false
                },
                new Models.Task
                {
                    Id = 6,
                    Title = "Monthly Team Performance Report",
                    Description = "Compile team performance data and create monthly report for agency management.",
                    DueDate = new DateTime(2025, 5, 30),
                    Priority = "Low",
                    Progress = 10,
                    Client = "Internal",
                    Tags = new List<string> { "Reporting", "Internal" },
                    AssignedTo = 1,
                    IsOverdue = false
                }
            };

            return Task.FromResult(tasks);
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
                    AdSpend = 42.5m,
                    IsOnline = true
                },
                new TeamMember
                {
                    Id = 2,
                    Name = "Michael Chen",
                    Role = "Campaign Specialist",
                    Email = "michael.c@agency.com",
                    ClientsManaged = 6,
                    CampaignsActive = 14,
                    AdSpend = 32.8m,
                    IsOnline = true
                },
                new TeamMember
                {
                    Id = 3,
                    Name = "Emily Rodriguez",
                    Role = "Client Success Manager",
                    Email = "emily.r@agency.com",
                    ClientsManaged = 10,
                    CampaignsActive = 22,
                    AdSpend = 58.3m,
                    IsOnline = false,
                    LastSeen = "15 minutes ago"
                },
                new TeamMember
                {
                    Id = 4,
                    Name = "David Kim",
                    Role = "Ad Operations Specialist",
                    Email = "david.k@agency.com",
                    ClientsManaged = 8,
                    CampaignsActive = 16,
                    AdSpend = 38.4m,
                    IsOnline = false,
                    LastSeen = "Away"
                },
                new TeamMember
                {
                    Id = 5,
                    Name = "Lisa Wong",
                    Role = "Creative Director",
                    Email = "lisa.w@agency.com",
                    ClientsManaged = 0,
                    CampaignsActive = 24,
                    AdSpend = 0,
                    IsOnline = false,
                    LastSeen = "2 hours ago"
                }
            };

            return Task.FromResult(teamMembers);
        }

        public Task<List<Alert>> GetAlertsAsync()
        {
            var alerts = new List<Alert>
            {
                new Alert { Id = 1, Type = "warning", Message = "NexGen Healthcare performance review task is overdue", Time = "2h ago" },
                new Alert { Id = 2, Type = "danger", Message = "FoodDelivery Plus campaign performance below target", Time = "4h ago" },
                new Alert { Id = 3, Type = "info", Message = "Team meeting scheduled for tomorrow at 10:00 AM", Time = "6h ago" },
                new Alert { Id = 4, Type = "success", Message = "GlobalRetail campaign setup approved by client", Time = "12h ago" },
                new Alert { Id = 5, Type = "info", Message = "New learning resources available: Performance Max Campaigns", Time = "1d ago" },
                new Alert { Id = 6, Type = "warning", Message = "Tech Solutions Inc approaching monthly budget limit", Time = "1d ago" }
            };

            return Task.FromResult(alerts);
        }
    }
}