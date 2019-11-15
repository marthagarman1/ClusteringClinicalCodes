using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicalCodeClusteringWebApp.Data.Migrations
{
    public partial class AddClaims : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    Claim_ID = table.Column<string>(unicode: false, maxLength: 120, nullable: false),
                    CPT = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Charge_Amount = table.Column<decimal>(unicode: false, maxLength: 50, nullable: false),
                    Payment_Amount = table.Column<decimal>(unicode: false, maxLength: 50, nullable: false),
                    Date_of_Submission = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => new { x.Claim_ID, x.CPT });
                });

            migrationBuilder.CreateTable(
                name: "CPT_Cats",
                columns: table => new
                {
                    Claim_ID = table.Column<string>(unicode: false, maxLength: 120, nullable: false),
                    DrugAssay = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Microbiology = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Chemistry = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DiseasePanels = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Hematology = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Immunology = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Urinalysis = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Claim_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "CPT_Cats");
        }
    }
}
