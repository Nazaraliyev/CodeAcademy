using Microsoft.EntityFrameworkCore.Migrations;

namespace Starx.Migrations
{
    public partial class ForegnKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_services_authors_AuthorId",
                table: "services");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "services",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_services_authors_AuthorId",
                table: "services",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_services_authors_AuthorId",
                table: "services");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "services",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_services_authors_AuthorId",
                table: "services",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
