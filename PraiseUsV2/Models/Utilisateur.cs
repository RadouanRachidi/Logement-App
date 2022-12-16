using System.ComponentModel.DataAnnotations;

namespace PraiseUsV1.Models;

public class Utilisateur
{
    [Key]
    public int Id_Utilisateur { get; set; }

    public string Nom { get; set; }

    public string? Prenom { get; set; }

    public DateTime Date_inscription { get; set; }

}
