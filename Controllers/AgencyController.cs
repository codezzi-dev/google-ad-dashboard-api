// Controllers/AgencyController.cs
using AgencyApi.Models;
using AgencyApi.Services;
using AgencyApis.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgencyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgencyController : ControllerBase
    {
        private readonly IAgencyService _agencyService;
        private readonly ILogger<AgencyController> _logger;

        public AgencyController(IAgencyService agencyService, ILogger<AgencyController> logger)
        {
            _agencyService = agencyService;
            _logger = logger;
        }

        [HttpGet("metrics")]
        public async Task<ActionResult<List<MetricCard>>> GetAgencyMetrics()
        {
            try
            {
                var metrics = await _agencyService.GetAgencyMetricsAsync();
                return Ok(metrics);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving agency metrics");
                return StatusCode(500, "An error occurred while retrieving agency metrics");
            }
        }

        [HttpGet("revenue-data")]
        public async Task<ActionResult<ChartData>> GetRevenueData()
        {
            try
            {
                var data = await _agencyService.GetRevenueDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving revenue data");
                return StatusCode(500, "An error occurred while retrieving revenue data");
            }
        }

        [HttpGet("campaign-performance")]
        public async Task<ActionResult<ChartData>> GetCampaignPerformanceData()
        {
            try
            {
                var data = await _agencyService.GetCampaignPerformanceDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving campaign performance data");
                return StatusCode(500, "An error occurred while retrieving campaign performance data");
            }
        }

        [HttpGet("client-growth")]
        public async Task<ActionResult<ChartData>> GetClientGrowthData()
        {
            try
            {
                var data = await _agencyService.GetClientGrowthDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving client growth data");
                return StatusCode(500, "An error occurred while retrieving client growth data");
            }
        }

        [HttpGet("ad-spend")]
        public async Task<ActionResult<ChartData>> GetAdSpendData()
        {
            try
            {
                var data = await _agencyService.GetAdSpendDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving ad spend data");
                return StatusCode(500, "An error occurred while retrieving ad spend data");
            }
        }

        [HttpGet("clients")]
        public async Task<ActionResult<List<Client>>> GetClients()
        {
            try
            {
                var clients = await _agencyService.GetClientsAsync();
                return Ok(clients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving clients");
                return StatusCode(500, "An error occurred while retrieving clients");
            }
        }

        [HttpGet("campaigns")]
        public async Task<ActionResult<List<Campaign>>> GetCampaigns()
        {
            try
            {
                var campaigns = await _agencyService.GetCampaignsAsync();
                return Ok(campaigns);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving campaigns");
                return StatusCode(500, "An error occurred while retrieving campaigns");
            }
        }

        [HttpGet("team-members")]
        public async Task<ActionResult<List<TeamMember>>> GetTeamMembers()
        {
            try
            {
                var teamMembers = await _agencyService.GetTeamMembersAsync();
                return Ok(teamMembers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving team members");
                return StatusCode(500, "An error occurred while retrieving team members");
            }
        }

        [HttpGet("alerts")]
        public async Task<ActionResult<List<Alert>>> GetAlerts()
        {
            try
            {
                var alerts = await _agencyService.GetAlertsAsync();
                return Ok(alerts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving alerts");
                return StatusCode(500, "An error occurred while retrieving alerts");
            }
        }
    }
}