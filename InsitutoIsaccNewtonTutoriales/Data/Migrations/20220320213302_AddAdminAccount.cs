using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Text;

namespace InsitutoIsaccNewtonTutoriales.Data.Migrations
{
    public partial class AddAdminAccount : Migration
    {
        const string ADMIN_USER_GUID = "9f807477-06f0-4768-9114-ffc69c574cdd";
        const string ADMIN_ROLE_GUID = "c0cc2cf6-5907-4a30-85de-77c9065ad6b1";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var passwordHash = hasher.HashPassword(null, "Password100!");

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("INSERT INTO AspNetUsers(Id,UserName,NormalizedUserName,Email,EmailConfirmed,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnabled,AccessFailedCount,NormalizedEmail,PasswordHash,SecurityStamp,FirstName)");
            sb.AppendLine("VALUES(");
            sb.AppendLine($"{ADMIN_USER_GUID}");
            sb.AppendLine(", 'ggmwba@gmail.com'");
            sb.AppendLine(", 'GGMWBA@GMAIL.COM'");
            sb.AppendLine(", 'ggmwba@gmail.com'");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 0");
            sb.AppendLine(", 'GGMWBA@GMAIL.COM'");
            sb.AppendLine($", '{passwordHash}'");
            sb.AppendLine($", ''");
            sb.AppendLine($", 'Admin'");
            sb.AppendLine(")");

            migrationBuilder.Sql(sb.ToString());

            migrationBuilder.Sql($"INSERT INTO AspNetRoles (Id, Name, NormalizedName) VALUES ('{ADMIN_ROLE_GUID}', 'Admin','ADMIN')");

            migrationBuilder.Sql($"INSERT INTO AspNetUserUsers (UserId, RoleId) VALUES ('{ADMIN_USER_GUID}','{ADMIN_ROLE_GUID}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM AspNetUserRoles WHERE UserId = '{ADMIN_USER_GUID}' AND RoleId = '{ADMIN_ROLE_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetUsers WHERE Id = '{ADMIN_USER_GUID}'");

            migrationBuilder.Sql($"DELETE FROM AspNetRoles WHERE Id = '{ADMIN_ROLE_GUID}'");
        }
    }
}
