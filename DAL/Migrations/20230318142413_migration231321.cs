using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class migration231321 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Notifications",
                newName: "UserReceieverId");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                newName: "IX_Notifications_UserReceieverId");

            migrationBuilder.AddColumn<int>(
                name: "UserSenderId",
                table: "Notifications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserSenderId",
                table: "Notifications",
                column: "UserSenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserReceieverId",
                table: "Notifications",
                column: "UserReceieverId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserSenderId",
                table: "Notifications",
                column: "UserSenderId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserReceieverId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Users_UserSenderId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_UserSenderId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "UserSenderId",
                table: "Notifications");

            migrationBuilder.RenameColumn(
                name: "UserReceieverId",
                table: "Notifications",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_UserReceieverId",
                table: "Notifications",
                newName: "IX_Notifications_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Users_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
