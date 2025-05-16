// Services/DashboardService.cs
using AgencyApi.Models;
using AgencyApi.Models.Dashboard;
using AgencyApis.Models;

namespace AgencyApi.Services
{
    public interface IDashboardService
    {
        Task<List<MetricCard>> GetFinancialMetricsAsync();
        Task<List<MetricCard>> GetCampaignMetricsAsync();
        Task<ChartData> GetRevenueDataAsync();
        Task<ChartData> GetQuarterlyDataAsync();
        Task<ChartData> GetPerformanceDataAsync();
        Task<ChartData> GetSubscriptionDataAsync();
        Task<ChartData> GetCampaignSummaryDataAsync();
        Task<List<Agency>> GetAgenciesAsync();
        Task<List<Client>> GetClientsAsync();
        Task<List<Alert>> GetAlertsAsync();
    }
}