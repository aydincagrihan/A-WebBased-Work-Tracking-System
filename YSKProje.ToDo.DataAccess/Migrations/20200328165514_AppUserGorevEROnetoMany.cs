using Microsoft.EntityFrameworkCore.Migrations;

namespace YSKProje.ToDo.DataAccess.Migrations
{
    public partial class AppUserGorevEROnetoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Calismalar",
                table: "Calismalar");

            migrationBuilder.RenameTable(
                name: "Calismalar",
                newName: "Gorevler");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Gorevler",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevler_AppUserId",
                table: "Gorevler",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_AspNetUsers_AppUserId",
                table: "Gorevler",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_AspNetUsers_AppUserId",
                table: "Gorevler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler");

            migrationBuilder.DropIndex(
                name: "IX_Gorevler_AppUserId",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Gorevler");

            migrationBuilder.RenameTable(
                name: "Gorevler",
                newName: "Calismalar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calismalar",
                table: "Calismalar",
                column: "Id");
        }
    }
}
