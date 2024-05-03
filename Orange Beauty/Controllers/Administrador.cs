using Microsoft.AspNetCore.Mvc;

namespace Orange_Beauty.Controllers
{
    public class Administrador : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
