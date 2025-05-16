// Controllers/ClientController.cs
using AgencyApi.Models;
using AgencyApi.Models.Client;
using AgencyApi.Services;
using Microsoft.AspNetCore.Mvc;
using Campaign = AgencyApi.Models.Client.ClientCampaign;

namespace AgencyApi.Controllers
{
    /// <summary>
    /// Controller for client dashboard operations
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly ILogger<ClientController> _logger;

        /// <summary>
        /// Initializes a new instance of the ClientController
        /// </summary>
        /// <param name="clientService">The client service</param>
        /// <param name="logger">The logger</param>
        public ClientController(IClientService clientService, ILogger<ClientController> logger)
        {
            _clientService = clientService;
            _logger = logger;
        }

        /// <summary>
        /// Gets client account details
        /// </summary>
        /// <returns>The client ad account details</returns>
        /// <response code="200">Returns the client account details</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("client-details")]
        [ProducesResponseType(typeof(AdAccount), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AdAccount>> GetClientDetails()
        {
            try
            {
                var clientDetails = await _clientService.GetClientDetailsAsync();
                return Ok(clientDetails);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving client details");
                return StatusCode(500, "An error occurred while retrieving client details");
            }
        }

        /// <summary>
        /// Gets performance metrics for the client
        /// </summary>
        /// <returns>A list of performance metric cards</returns>
        /// <response code="200">Returns the performance metrics</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("performance-metrics")]
        [ProducesResponseType(typeof(List<MetricCard>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<MetricCard>>> GetPerformanceMetrics()
        {
            try
            {
                var metrics = await _clientService.GetPerformanceMetricsAsync();
                return Ok(metrics);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving performance metrics");
                return StatusCode(500, "An error occurred while retrieving performance metrics");
            }
        }

        /// <summary>
        /// Gets performance trends chart data
        /// </summary>
        /// <returns>Chart data for performance trends</returns>
        /// <response code="200">Returns the performance trends chart data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("performance-trends")]
        [ProducesResponseType(typeof(ChartData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ChartData>> GetPerformanceTrendsData()
        {
            try
            {
                var data = await _clientService.GetPerformanceTrendsDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving performance trends data");
                return StatusCode(500, "An error occurred while retrieving performance trends data");
            }
        }

        /// <summary>
        /// Gets budget data for charts
        /// </summary>
        /// <returns>Chart data for budget visualization</returns>
        /// <response code="200">Returns the budget chart data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("budget-data")]
        [ProducesResponseType(typeof(ChartData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ChartData>> GetBudgetData()
        {
            try
            {
                var data = await _clientService.GetBudgetDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving budget data");
                return StatusCode(500, "An error occurred while retrieving budget data");
            }
        }

        /// <summary>
        /// Gets conversion data for charts
        /// </summary>
        /// <returns>Chart data for conversion visualization</returns>
        /// <response code="200">Returns the conversion chart data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("conversion-data")]
        [ProducesResponseType(typeof(ChartData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ChartData>> GetConversionData()
        {
            try
            {
                var data = await _clientService.GetConversionDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving conversion data");
                return StatusCode(500, "An error occurred while retrieving conversion data");
            }
        }

        /// <summary>
        /// Gets campaign performance data for charts
        /// </summary>
        /// <returns>Chart data for campaign performance visualization</returns>
        /// <response code="200">Returns the campaign performance chart data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("campaign-performance")]
        [ProducesResponseType(typeof(ChartData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ChartData>> GetCampaignPerformanceData()
        {
            try
            {
                var data = await _clientService.GetCampaignPerformanceDataAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving campaign performance data");
                return StatusCode(500, "An error occurred while retrieving campaign performance data");
            }
        }

        /// <summary>
        /// Gets list of active campaigns
        /// </summary>
        /// <returns>List of active campaigns</returns>
        /// <response code="200">Returns the active campaigns</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("active-campaigns")]
        [ProducesResponseType(typeof(List<Campaign>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<Campaign>>> GetActiveCampaigns()
        {
            try
            {
                var campaigns = await _clientService.GetActiveCampaignsAsync();
                return Ok(campaigns);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving active campaigns");
                return StatusCode(500, "An error occurred while retrieving active campaigns");
            }
        }

        /// <summary>
        /// Gets list of ad creatives
        /// </summary>
        /// <returns>List of ad creatives</returns>
        /// <response code="200">Returns the ad creatives</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("creatives")]
        [ProducesResponseType(typeof(List<AdCreative>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<AdCreative>>> GetCreatives()
        {
            try
            {
                var creatives = await _clientService.GetCreativesAsync();
                return Ok(creatives);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving ad creatives");
                return StatusCode(500, "An error occurred while retrieving ad creatives");
            }
        }

        /// <summary>
        /// Gets list of client updates
        /// </summary>
        /// <returns>List of updates</returns>
        /// <response code="200">Returns the updates</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("updates")]
        [ProducesResponseType(typeof(List<Update>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<Update>>> GetUpdates()
        {
            try
            {
                var updates = await _clientService.GetUpdatesAsync();
                return Ok(updates);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving updates");
                return StatusCode(500, "An error occurred while retrieving updates");
            }
        }

        /// <summary>
        /// Gets list of client reports
        /// </summary>
        /// <returns>List of reports</returns>
        /// <response code="200">Returns the reports</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("reports")]
        [ProducesResponseType(typeof(List<Report>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<Report>>> GetReports()
        {
            try
            {
                var reports = await _clientService.GetReportsAsync();
                return Ok(reports);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving reports");
                return StatusCode(500, "An error occurred while retrieving reports");
            }
        }

        /// <summary>
        /// Gets list of client alerts
        /// </summary>
        /// <returns>List of alerts</returns>
        /// <response code="200">Returns the alerts</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("alerts")]
        [ProducesResponseType(typeof(List<Alert>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<Alert>>> GetAlerts()
        {
            try
            {
                var alerts = await _clientService.GetAlertsAsync();
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