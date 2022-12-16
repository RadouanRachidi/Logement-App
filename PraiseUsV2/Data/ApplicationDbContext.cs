using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PraiseUsV1.Models;
using PraiseUsV2.Models;

namespace PraiseUsV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<Avis> Locataire_Avis { get; set; }

    }
}