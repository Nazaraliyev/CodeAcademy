using Microsoft.EntityFrameworkCore.Migrations;

namespace Simple_API.Migrations
{
    public partial class FacultySmallName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SmaaName",
                table: "faculties",
                newName: "SmallName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SmallName",
                table: "faculties",
                newName: "SmaaName");
        }
    }
}
