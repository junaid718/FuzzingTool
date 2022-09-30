using Microsoft.AspNetCore.Mvc;

namespace FuzzingTool.Controllers
{
    public class ProxyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
