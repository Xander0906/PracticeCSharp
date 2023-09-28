using Microsoft.AspNetCore.Mvc;

namespace MvcAspDotNet.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
