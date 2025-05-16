// Controllers/TeamController.cs
using AgencyApi.Models;
using AgencyApi.Services;
using AgencyApis.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgencyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;
        private readonly ILogger<TeamController> _logger;

        public TeamController(ITeamService teamService, ILogger<TeamController> logger)
        {
            _teamService = teamService;
            _logger = logger;
        }

        [HttpGet("current-user")]
        public async Task<ActionResult<TeamMember>> GetCurrentUser()
        {
            try
            {
                var user = await _teamService.GetCurrentUserAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving current user");
                return StatusCode(500, "An error occurred while retrieving current user");
            }
        }

        [HttpGet("performance-metrics")]
        public async Task<ActionResult<List<MetricCard>>> GetPerformanceMetrics()
        {
            try
            {
                var metrics = await _teamService.GetPerformanceMetricsAsync();
                return Ok(metrics);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving performance metrics");
                return StatusCode(500, "An error occurred while retrieving performance metrics");
            }
        }

        [HttpGet("performance-trends")]
        public async Task<ActionResult<ChartData>> GetPerformanceTrendsData()
        {
            try
            {
                var data = await _teamService.GetPerformanceTrendsDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving performance trends data");
                return StatusCode(500, "An error occurred while retrieving performance trends data");
            }
        }

        [HttpGet("client-distribution")]
        public async Task<ActionResult<ChartData>> GetClientDistributionData()
        {
            try
            {
                var data = await _teamService.GetClientDistributionDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving client distribution data");
                return StatusCode(500, "An error occurred while retrieving client distribution data");
            }
        }

        [HttpGet("weekly-activity")]
        public async Task<ActionResult<ChartData>> GetWeeklyActivityData()
        {
            try
            {
                var data = await _teamService.GetWeeklyActivityDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving weekly activity data");
                return StatusCode(500, "An error occurred while retrieving weekly activity data");
            }
        }

        [HttpGet("assigned-clients")]
        public async Task<ActionResult<List<Client>>> GetAssignedClients()
        {
            try
            {
                var clients = await _teamService.GetAssignedClientsAsync();
                return Ok(clients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving assigned clients");
                return StatusCode(500, "An error occurred while retrieving assigned clients");
            }
        }

        [HttpGet("assigned-campaigns")]
        public async Task<ActionResult<List<Campaign>>> GetAssignedCampaigns()
        {
            try
            {
                var campaigns = await _teamService.GetAssignedCampaignsAsync();
                return Ok(campaigns);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving assigned campaigns");
                return StatusCode(500, "An error occurred while retrieving assigned campaigns");
            }
        }

        [HttpGet("assigned-tasks")]
        public async Task<ActionResult<List<Models.Task>>> GetAssignedTasks()
        {
            try
            {
                var tasks = await _teamService.GetAssignedTasksAsync();
                return Ok(tasks);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving assigned tasks");
                return StatusCode(500, "An error occurred while retrieving assigned tasks");
            }
        }

        [HttpGet("team-members")]
        public async Task<ActionResult<List<TeamMember>>> GetTeamMembers()
        {
            try
            {
                var teamMembers = await _teamService.GetTeamMembersAsync();
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
                var alerts = await _teamService.GetAlertsAsync();
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