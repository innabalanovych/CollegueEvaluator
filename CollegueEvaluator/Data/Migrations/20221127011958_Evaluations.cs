using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegueEvaluator.Data.Migrations
{
    public partial class Evaluations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"CREATE TABLE Evaluations (" +
                "Id nvarchar(450) NOT NULL," +
                "UserId nvarchar(450) NOT NULL," +
                "Responsibility nvarchar(450) NOT NULL," +
                "Performance nvarchar(450) NOT NULL," +
                "СommunicationSkills nvarchar(450) NOT NULL," +
                "Qualification nvarchar(450) NOT NULL," +
                "PRIMARY KEY (Id));");      
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DROP TABLE Evaluations;");
        }
    }
}
