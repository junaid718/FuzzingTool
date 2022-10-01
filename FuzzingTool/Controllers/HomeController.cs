using FuzzingTool.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
/**
 * This controller is an entry point
 */
namespace FuzzingTool.Controllers
{
    public class HomeController : Controller
    {
        //IActionResult Finds Same Name(Home) and its cdhtml index
        //View is the content inside Home/index.cshtml
        public IActionResult Index()
        {
            return View();
        }
      
    }
}