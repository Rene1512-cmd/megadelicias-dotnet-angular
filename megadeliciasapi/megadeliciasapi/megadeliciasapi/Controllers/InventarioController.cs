using Microsoft.AspNetCore.Mvc;

namespace megadeliciasapi.Controllers
{
    public class InventarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
