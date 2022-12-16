using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using PraiseUsV1.Models;

namespace PraiseUsV2.Models;

public class Avis
{

    [Key]
    public int Id_Locataire { get; set; }

    public string Nom { get; set; }

    public string Prenom { get; set; }

    public int Note { get; set; }

    public string Commentaire { get; set; }

    public DateTime Date_avis { get; set; }

    public virtual Utilisateur Utilisateur { get; set; }


}
