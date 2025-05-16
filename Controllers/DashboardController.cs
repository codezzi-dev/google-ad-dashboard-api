// Controllers/DashboardController.cs
using AgencyApi.Models;
using AgencyApi.Models.Dashboard;
using AgencyApi.Services;
using AgencyApis.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgencyApi.Controllers
{
    /// <summary>
    /// Controller for admin dashboard operations
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        private readonly ILogger<DashboardController> _logger;

        /// <summary>
        /// Initializes a new instance of the DashboardController
        /// </summary>
        /// <param name="dashboardService">The dashboard service</param>
        /// <param name="logger">The logger</param>
        public DashboardController(IDashboardService dashboardService, ILogger<DashboardController> logger)
        {
            _dashboardService = dashboardService;
            _logger = logger;
        }

        /// <summary>
        /// Gets financial metrics for the dashboard
        /// </summary>
        /// <returns>A list of financial metric cards</returns>
        /// <response code="200">Returns the financial metrics</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("financial-metrics")]
        [ProducesResponseType(typeof(List<MetricCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<MetricCard>>> GetFinancialMetrics()
        {
            try
            {
                var metrics = await _dashboardService.GetFinancialMetricsAsync();
                return Ok(metrics);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving financial metrics");
                return StatusCode(500, "An error occurred while retrieving financial metrics");
            }
        }

        /// <summary>
        /// Gets campaign metrics for the dashboard
        /// </summary>
        /// <returns>A list of campaign metric cards</returns>
        /// <response code="200">Returns the campaign metrics</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("campaign-metrics")]
        [ProducesResponseType(typeof(List<MetricCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<MetricCard>>> GetCampaignMetrics()
        {
            try
            {
                var metrics = await _dashboardService.GetCampaignMetricsAsync();
                return Ok(metrics);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving campaign metrics");
                return StatusCode(500, "An error occurred while retrieving campaign metrics");
            }
        }

        /// <summary>
        /// Gets revenue data for charts
        /// </summary>
        /// <returns>Chart data for revenue visualization</returns>
        /// <response code="200">Returns the revenue chart data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("revenue-data")]
        [ProducesResponseType(typeof(ChartData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ChartData>> GetRevenueData()
        {
            try
            {
                var data = await _dashboardService.GetRevenueDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving revenue data");
                return StatusCode(500, "An error occurred while retrieving revenue data");
            }
        }

        /// <summary>
        /// Gets quarterly data for charts
        /// </summary>
        /// <returns>Chart data for quarterly visualization</returns>
        /// <response code="200">Returns the quarterly chart data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("quarterly-data")]
        [ProducesResponseType(typeof(ChartData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ChartData>> GetQuarterlyData()
        {
            try
            {
                var data = await _dashboardService.GetQuarterlyDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving quarterly data");
                return StatusCode(500, "An error occurred while retrieving quarterly data");
            }
        }

        /// <summary>
        /// Gets performance data for charts
        /// </summary>
        /// <returns>Chart data for performance visualization</returns>
        /// <response code="200">Returns the performance chart data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("performance-data")]
        [ProducesResponseType(typeof(ChartData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ChartData>> GetPerformanceData()
        {
            try
            {
                var data = await _dashboardService.GetPerformanceDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving performance data");
                return StatusCode(500, "An error occurred while retrieving performance data");
            }
        }

        /// <summary>
        /// Gets subscription data for charts
        /// </summary>
        /// <returns>Chart data for subscription visualization</returns>
        /// <response code="200">Returns the subscription chart data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("subscription-data")]
        [ProducesResponseType(typeof(ChartData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ChartData>> GetSubscriptionData()
        {
            try
            {
                var data = await _dashboardService.GetSubscriptionDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving subscription data");
                return StatusCode(500, "An error occurred while retrieving subscription data");
            }
        }

        /// <summary>
        /// Gets campaign summary data for charts
        /// </summary>
        /// <returns>Chart data for campaign summary visualization</returns>
        /// <response code="200">Returns the campaign summary chart data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("campaign-summary")]
        [ProducesResponseType(typeof(ChartData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ChartData>> GetCampaignSummaryData()
        {
            try
            {
                var data = await _dashboardService.GetCampaignSummaryDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving campaign summary data");
                return StatusCode(500, "An error occurred while retrieving campaign summary data");
            }
        }

        /// <summary>
        /// Gets list of agencies
        /// </summary>
        /// <returns>List of agencies</returns>
        /// <response code="200">Returns the agencies list</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("agencies")]
        [ProducesResponseType(typeof(List<Agency>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<Agency>>> GetAgencies()
        {
            try
            {
                var agencies = await _dashboardService.GetAgenciesAsync();
                return Ok(agencies);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving agencies");
                return StatusCode(500, "An error occurred while retrieving agencies");
            }
        }

        /// <summary>
        /// Gets list of clients
        /// </summary>
        /// <returns>List of clients</returns>
        /// <response code="200">Returns the clients list</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("clients")]
        [ProducesResponseType(typeof(List<Client>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<Client>>> GetClients()
        {
            try
            {
                var clients = await _dashboardService.GetClientsAsync();
                return Ok(clients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving clients");
                return StatusCode(500, "An error occurred while retrieving clients");
            }
        }

        /// <summary>
        /// Gets list of alerts
        /// </summary>
        /// <returns>List of alerts</returns>
        /// <response code="200">Returns the alerts list</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("alerts")]
        [ProducesResponseType(typeof(List<Alert>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<Alert>>> GetAlerts()
        {
            try
            {
                var alerts = await _dashboardService.GetAlertsAsync();
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