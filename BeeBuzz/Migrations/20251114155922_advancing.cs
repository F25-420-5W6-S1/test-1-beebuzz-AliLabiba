using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeeBuzz.Migrations
{
    /// <inheritdoc />
    public partial class advancing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrganizationName",
                table: "Beehive");

            migrationBuilder.RenameColumn(
                name: "reasoneOfDeactivation",
                table: "Beehive",
                newName: "ReasoneOfDeactivation");

            migrationBuilder.AlterColumn<string>(
                name: "ReasoneOfDeactivation",
                table: "Beehive",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Beehive",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "organizationId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Beehive");

            migrationBuilder.DropColumn(
                name: "organizationId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ReasoneOfDeactivation",
                table: "Beehive",
                newName: "reasoneOfDeactivation");

            migrationBuilder.AlterColumn<string>(
                name: "reasoneOfDeactivation",
                table: "Beehive",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrganizationName",
                table: "Beehive",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
