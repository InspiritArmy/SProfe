using Microsoft.AspNetCore.Mvc;

namespace SprofeOficial.Controllers
{
    public class IndexInsideController : Controller
    {
        public IActionResult IndexIs()
        {
            return View();
        }
    }
}