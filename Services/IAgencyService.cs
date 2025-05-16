using AgencyApi.Models;
using AgencyApis.Models;

namespace AgencyApi.Services
{
    public interface IAgencyService
    {
        Task<List<MetricCard>> GetAgencyMetricsAsync();
        Task<ChartData> GetRevenueDataAsync();
        Task<ChartData> GetCampaignPerformanceDataAsync();
        Task<ChartData> GetClientGrowthDataAsync();
        Task<ChartData> GetAdSpendDataAsync();
        Task<List<Client>> GetClientsAsync();
        Task<List<Campaign>> GetCampaignsAsync();
        Task<List<TeamMember>> GetTeamMembersAsync();
        Task<List<Alert>> GetAlertsAsync();
    }
}