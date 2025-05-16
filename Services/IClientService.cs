// Services/IClientService.cs
using AgencyApi.Models;
using AgencyApi.Models.Client;
using Campaign = AgencyApi.Models.Client.ClientCampaign;

namespace AgencyApi.Services
{
    public interface IClientService
    {
        Task<AdAccount> GetClientDetailsAsync();
        Task<List<MetricCard>> GetPerformanceMetricsAsync();
        Task<ChartData> GetPerformanceTrendsDataAsync();
        Task<ChartData> GetBudgetDataAsync();
        Task<ChartData> GetConversionDataAsync();
        Task<ChartData> GetCampaignPerformanceDataAsync();
        Task<List<Campaign>> GetActiveCampaignsAsync();
        Task<List<AdCreative>> GetCreativesAsync();
        Task<List<Update>> GetUpdatesAsync();
        Task<List<Report>> GetReportsAsync();
        Task<List<Alert>> GetAlertsAsync();
    }
}