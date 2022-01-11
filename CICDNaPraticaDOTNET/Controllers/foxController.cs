using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace CICDNaPraticaDOTNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class foxController : ControllerBase
    {
        public static string BaseURL = "https://raw.githubusercontent.com/Fox-Tan/CICDNaPraticaDOTNET/main/Images/Fox/";
        private readonly ILogger<foxController> _logger;
        public foxController(ILogger<foxController> logger, IConfiguration configuration) => _logger = logger;
        [HttpGet]
        public IActionResult Get(bool image)
        {
            Random random = new Random();
            string url = $"{BaseURL}{random.Next(1, 10)}.jpg";
            if (image)
            {
                using (var webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(url);
                    return File(imageBytes, "image/jpg");
                }
            }
            else return Ok(url);
        }
    }
}