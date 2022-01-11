using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace CICDNaPraticaDOTNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class imagesController : ControllerBase
    {
        public static string BaseURL = "https://raw.githubusercontent.com/Fox-Tan/CICDNaPraticaDOTNET/main/Images/";
        private readonly ILogger<imagesController> _logger;
        public imagesController(ILogger<imagesController> logger, IConfiguration configuration) => _logger = logger;
        // Pega as imagens da pasta Images
        [HttpGet]
        public IActionResult Get(bool image=false, int category=1)
        {
            Random random = new Random();
            string url = String.Empty;
            // Define para qual pasta de imagem será redirecionado
            switch (category)
            {
                case 1: // Define a pasta de imagens de gatos
                    url = $"{BaseURL}Cat/{random.Next(1, 10)}.jpg";
                    break;
                case 2: // Define a pasta de imagens de cachorros
                    url = $"{BaseURL}Dog/{random.Next(1, 10)}.jpg";
                    break;
                case 3: // Define a pasta de imagens de raposas
                    url = $"{BaseURL}Fox/{random.Next(1, 10)}.jpg";
                    break;
                case 4: // Define a pasta de imagens de tartarugas
                    url = $"{BaseURL}Turtle/{random.Next(1, 10)}.jpg";
                    break;
                case 5: // Define a pasta de imagens de peixes
                    url = $"{BaseURL}Fish/{random.Next(1, 10)}.jpg";
                    break;
                case 6: // Define a pasta de imagens de hamsters
                    url = $"{BaseURL}hamster/{random.Next(1, 10)}.jpg";
                    break;
                case 7: // Define a pasta de imagens de Animes
                    url = $"{BaseURL}Anime/{random.Next(1, 10)}.jpg";
                    break;
                default: // Não encontrou o endereço especificado apresentando o erro 404 Not found
                    return NotFound(url);
            }
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