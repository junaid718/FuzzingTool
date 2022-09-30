using Microsoft.AspNetCore.Mvc;

namespace FuzzingTool.Controllers
{
    public class TargetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
