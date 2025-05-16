using AgencyApi.Models;
using AgencyApis.Models;

namespace AgencyApi.Services
{
    public interface ITeamService
    {
        Task<TeamMember> GetCurrentUserAsync();
        Task<List<MetricCard>> GetPerformanceMetricsAsync();
        Task<ChartData> GetPerformanceTrendsDataAsync();
        Task<ChartData> GetClientDistributionDataAsync();
        Task<ChartData> GetWeeklyActivityDataAsync();
        Task<List<Client>> GetAssignedClientsAsync();
        Task<List<Campaign>> GetAssignedCampaignsAsync();
        Task<List<Models.Task>> GetAssignedTasksAsync();
        Task<List<TeamMember>> GetTeamMembersAsync();
        Task<List<Alert>> GetAlertsAsync();
    }
}