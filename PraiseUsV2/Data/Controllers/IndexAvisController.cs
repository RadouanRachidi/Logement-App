using Microsoft.AspNetCore.Mvc;
using PraiseUsV2.Models;
using System.Diagnostics;

namespace PraiseUsV2.Controllers
{
    public class IndexAvisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
} 