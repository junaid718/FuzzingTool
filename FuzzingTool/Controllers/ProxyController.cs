using Microsoft.AspNetCore.Mvc;
/**
 * Proxy management page entry
 * Sub-functions: HTTP history, websockets history, Intercept
 */
namespace FuzzingTool.Controllers
{
    public class ProxyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Proxy/HisHTTP")]
        public IActionResult HisHTTP()
        {
            return View();
        }

        [Route("/Proxy/hisWebSocket")]
        public IActionResult hisWebSocket()
        {
            return View();
        }

        [Route("/Proxy/Intercept")]
        public IActionResult Intercept()
        {
            return View();
        }
    }
}
