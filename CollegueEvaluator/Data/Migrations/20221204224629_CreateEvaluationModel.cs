using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegueEvaluator.Data.Migrations
{
    public partial class CreateEvaluationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluatedUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Performance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    СommunicationSkills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evaluations");
        }
    }
}
