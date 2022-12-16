using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PraiseUsV2.Data;

namespace PraiseUsV2.Models
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Avis Avis { get; set; } 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Locataire_Avis == null)
            {
                return NotFound();
            }

            var avis = await _context.Locataire_Avis.FirstOrDefaultAsync(m => m.Id_Locataire == id);
            if (avis == null)
            {
                return NotFound();
            }
            else
            {
                Avis = avis;
            }
            return Page();
        }
    }
}
