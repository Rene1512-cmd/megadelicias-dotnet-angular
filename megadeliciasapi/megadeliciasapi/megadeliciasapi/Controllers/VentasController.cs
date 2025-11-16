using Microsoft.AspNetCore.Mvc;

namespace megadeliciasapi.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
