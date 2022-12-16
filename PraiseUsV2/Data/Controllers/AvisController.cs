using Microsoft.AspNetCore.Mvc;
using PraiseUsV2.Models;
using System.Diagnostics;

namespace PraiseUsV2.Controllers
{
    public class AvisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult My_Avis()
        {
            return View();
        }

        public IActionResult New_Avis()
        {
            return View();
        }

    }
}