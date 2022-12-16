using Microsoft.AspNetCore.Mvc;
using PraiseUsV2.Models;
using System.Diagnostics;

namespace PraiseUsV2.Controllers
{
    public class DetailsAvisController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
        
    }
}