using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeeBuzz.Migrations
{
    /// <inheritdoc />
    public partial class theBestICould : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beehive_AspNetUsers_ApplicationUserId",
                table: "Beehive");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beehive",
                table: "Beehive");

            migrationBuilder.RenameTable(
                name: "Beehive",
                newName: "Beehives");

            migrationBuilder.RenameIndex(
                name: "IX_Beehive_ApplicationUserId",
                table: "Beehives",
                newName: "IX_Beehives_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beehives",
                table: "Beehives",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beehives_AspNetUsers_ApplicationUserId",
                table: "Beehives",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beehives_AspNetUsers_ApplicationUserId",
                table: "Beehives");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Beehives",
                table: "Beehives");

            migrationBuilder.RenameTable(
                name: "Beehives",
                newName: "Beehive");

            migrationBuilder.RenameIndex(
                name: "IX_Beehives_ApplicationUserId",
                table: "Beehive",
                newName: "IX_Beehive_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Beehive",
                table: "Beehive",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beehive_AspNetUsers_ApplicationUserId",
                table: "Beehive",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
