using Microsoft.AspNetCore.Mvc;

namespace megadeliciasapi.Controllers
{
    public class OrdenesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
