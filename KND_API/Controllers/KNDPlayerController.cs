using KNDPlayerDataAccess;
using Microsoft.AspNetCore.Mvc;

namespace KND_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KNDPlayerController : ControllerBase
    {
        private readonly ILogger<KNDPlayerController> _logger;

        public KNDPlayerController(ILogger<KNDPlayerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/HelloWorld", Name = "GetKNDPlayers")]
        public IEnumerable<KNDPlayer> Get()
        {
            return KNDPlayerDataAccessExtensions.Get_Players().ToArray();
        }
    }
}