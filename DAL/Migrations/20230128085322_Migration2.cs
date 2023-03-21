using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Users_UserId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_UserId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Countries");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CountryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_UserId",
                table: "Countries",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Users_UserId",
                table: "Countries",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
