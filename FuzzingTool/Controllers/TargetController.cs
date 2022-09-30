using Microsoft.AspNetCore.Mvc;

namespace FuzzingTool.Controllers
{
    public class TargetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Target/IssueDef")]
        public IActionResult IssueDef()
        {
            return View();
        }
        [Route("/Target/Scope")]
        public IActionResult Scope()
        {
            return View();
        }
        [Route("/Target/SiteMap")]
        public IActionResult SiteMap()
        {
            return View();
        }
    }
}
