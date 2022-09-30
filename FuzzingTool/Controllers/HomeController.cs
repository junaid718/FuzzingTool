using FuzzingTool.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FuzzingTool.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
    }
}