using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraiseUsV2.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id_Utilisateur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_inscription = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id_Utilisateur);
                });

            migrationBuilder.CreateTable(
                name: "Locataire_Avis",
                columns: table => new
                {
                    Id_Locataire = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<int>(type: "int", nullable: false),
                    Commentaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_avis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurId_Utilisateur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataire_Avis", x => x.Id_Locataire);
                    table.ForeignKey(
                        name: "FK_Locataire_Avis_Utilisateur_UtilisateurId_Utilisateur",
                        column: x => x.UtilisateurId_Utilisateur,
                        principalTable: "Utilisateur",
                        principalColumn: "Id_Utilisateur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locataire_Avis_UtilisateurId_Utilisateur",
                table: "Locataire_Avis",
                column: "UtilisateurId_Utilisateur");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locataire_Avis");

            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
