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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Avis> Avis { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Locataire_Avis != null)
            {
                Avis = await _context.Locataire_Avis.ToListAsync();
            }
        }
    }
}
