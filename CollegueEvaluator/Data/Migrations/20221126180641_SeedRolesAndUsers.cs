using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

#nullable disable

namespace CollegueEvaluator.Data.Migrations
{
    public partial class SeedRolesAndUsers : Migration
    {
        const string ADMIN_USER_GUID = "4572a6c9-f747-4376-bb9d-a8e042ec24ae";
        const string ADMIN_ROLE_GUID = "663a64fd-8c53-4aa5-99bb-8a464f436de6";

        const string NON_ADMIN_USER_GUID = "4572a6c9-f747-4376-bb9d-a8e042ec24aa";
        const string NON_ADMIN_ROLE_GUID = "663a64fd-8c53-4aa5-99bb-8a464f436dea";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            InitAdmin(migrationBuilder);
            InitNonAdmin(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{NON_ADMIN_USER_GUID}' AND RoleId = '{NON_ADMIN_ROLE_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{ADMIN_USER_GUID}'");
            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{NON_ADMIN_USER_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{ADMIN_ROLE_GUID}'");
            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{NON_ADMIN_ROLE_GUID}'");
        }

        public static void InitAdmin(MigrationBuilder migrationBuilder)
        {
            InitUserWithRole("admin", "Admin", migrationBuilder, ADMIN_USER_GUID, ADMIN_ROLE_GUID);

        }
        public static void InitNonAdmin(MigrationBuilder migrationBuilder)
        {
            InitUserWithRole("user", "Limited", migrationBuilder, NON_ADMIN_USER_GUID, NON_ADMIN_ROLE_GUID);

        }
        public static void InitUserWithRole(string name, string role, MigrationBuilder migrationBuilder, string userId, string roleId)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            var passwordHash = hasher.HashPassword(null, "Aa1234#");
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("INSERT INTO AspNetUsers(Id, UserName, NormalizedUserName,Email,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,NormalizedEmail,PasswordHash,SecurityStamp)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"'{userId}'");
            sb.AppendLine(",'" + name + "@evaluator.com'");
            sb.AppendLine(",'" + name.ToUpper() + "@EVALUATOR.COM'");
            sb.AppendLine(",'" + name + "@evaluator.com'");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(",'" + name.ToUpper() + "@EVALUATOR.COM'");
            sb.AppendLine($", '{passwordHash}'");
            sb.AppendLine(", ''");
            sb.AppendLine(")");

            migrationBuilder.Sql(sb.ToString());

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{roleId}','" + role + "','" + role.ToUpper() + "')");

            migrationBuilder.Sql($"INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES ('{userId}','{roleId}')");
        }
    }
}
