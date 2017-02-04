using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return Json("sample c# snake for battle snake");
        }

        [HttpPost]
        public IActionResult Start([FromBody] GameStartRequest request)
        {
            return Json(new GameStartResponse
            {
                Color = "#00FF00",
                Name = "Bear Snake",
                HeadUrl = "https://placebear.com/100/100"
            });
        }

        [HttpPost]
        public IActionResult Move([FromBody] MoveRequest request)
        {
            return Json(new MoveResponse
            {
                Move = "up"
            });
        }
    }
}
