using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace DotnetCoreRateLimit.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableRateLimiting("fixed")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        // GET: ProductController
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public ActionResult RateLimitFixed()
        {
            _logger.LogInformation($"Visit {nameof(RateLimitFixed)} - {DateTime.Now}");
            return Ok(nameof(RateLimitFixed));
        }

        [HttpGet]
        [EnableRateLimiting("sliding")]
        public ActionResult RateLimitSliding()
        {
            _logger.LogInformation($"Visit {nameof(RateLimitSliding)} - {DateTime.Now}");
            return Ok(nameof(RateLimitSliding));
        }

        [HttpGet]
        [EnableRateLimiting("token")]
        public ActionResult RateLimitToken()
        {
            _logger.LogInformation($"Visit {nameof(RateLimitToken)} - {DateTime.Now}");
            return Ok(nameof(RateLimitToken));
        }

        [HttpGet]
        [EnableRateLimiting("concurrency")]
        public ActionResult RateLimitConcurrency()
        {
            _logger.LogInformation($"Visit {nameof(RateLimitConcurrency)} - {DateTime.Now}");
            return Ok(nameof(RateLimitConcurrency));
        }

        
    }
}
