using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class mig232 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Messages2_Message2MessageId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Messages2_Message2MessageId1",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_Message2MessageId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_Message2MessageId1",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Message2MessageId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Message2MessageId1",
                table: "Messages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Message2MessageId",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Message2MessageId1",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Message2MessageId",
                table: "Messages",
                column: "Message2MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Message2MessageId1",
                table: "Messages",
                column: "Message2MessageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Messages2_Message2MessageId",
                table: "Messages",
                column: "Message2MessageId",
                principalTable: "Messages2",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Messages2_Message2MessageId1",
                table: "Messages",
                column: "Message2MessageId1",
                principalTable: "Messages2",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
