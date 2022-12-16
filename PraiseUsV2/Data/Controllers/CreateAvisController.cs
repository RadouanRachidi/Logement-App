using Microsoft.AspNetCore.Mvc;
using PraiseUsV1.Models;
using PraiseUsV2.Models;

namespace PraiseUsV2.Data.Controllers
{
    public class CreateAvisController : Controller
    {
        private readonly ApplicationDbContext _context;
      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OnGet()
        {
            return View();
        }

        [BindProperty] 
        public Avis Avis { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> Create(Avis avis)
        {
            /*if (!ModelState.IsValid)
            {
                return View();
            }
                */
            Utilisateur user1= new Utilisateur();
            user1.Id_Utilisateur = 1;
            avis.Utilisateur = user1;
            avis.Id_Locataire = 1;

            _context.Locataire_Avis.Add(avis);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
