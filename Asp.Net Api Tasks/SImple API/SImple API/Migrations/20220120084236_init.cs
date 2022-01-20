using Microsoft.EntityFrameworkCore.Migrations;

namespace Simple_API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "degres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_degres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SmaaName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FreeScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaidScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_qualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_qualifications_faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    DegreId = table.Column<int>(type: "int", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_classes_degres_DegreId",
                        column: x => x.DegreId,
                        principalTable: "degres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_classes_qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_students_levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_classes_DegreId",
                table: "classes",
                column: "DegreId");

            migrationBuilder.CreateIndex(
                name: "IX_classes_QualificationId",
                table: "classes",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_qualifications_FacultyId",
                table: "qualifications",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_students_ClassId",
                table: "students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_students_LevelId",
                table: "students",
                column: "LevelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.DropTable(
                name: "levels");

            migrationBuilder.DropTable(
                name: "degres");

            migrationBuilder.DropTable(
                name: "qualifications");

            migrationBuilder.DropTable(
                name: "faculties");
        }
    }
}
