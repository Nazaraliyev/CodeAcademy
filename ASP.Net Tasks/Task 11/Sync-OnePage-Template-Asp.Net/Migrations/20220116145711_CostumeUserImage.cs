using Microsoft.EntityFrameworkCore.Migrations;

namespace Sync_OnePage_Template_Asp.Net.Migrations
{
    public partial class CostumeUserImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Profile",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profile",
                table: "AspNetUsers");
        }
    }
}
