using Microsoft.AspNetCore.Mvc;

namespace Aprendizagem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
