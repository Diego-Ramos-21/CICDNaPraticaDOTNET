using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace CICDNaPraticaDOTNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class fishController : ControllerBase
    {
        public static string BaseURL = "https://raw.githubusercontent.com/Fox-Tan/CICDNaPraticaDOTNET/main/Images/Fish/";
        private readonly ILogger<fishController> _logger;
        public fishController(ILogger<fishController> logger, IConfiguration configuration) => _logger = logger;
        // Pega as imagens da pasta Images
        [HttpGet]
        public IActionResult Get(bool image)
        {
            Random random = new Random();
            string url = $"{BaseURL}{random.Next(1, 10)}.jpg";
            // Define se mostrará a imagem ou somente o Json
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