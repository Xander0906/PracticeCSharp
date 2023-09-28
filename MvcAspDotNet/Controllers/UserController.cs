using Microsoft.AspNetCore.Mvc;

namespace MvcAspDotNet.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
