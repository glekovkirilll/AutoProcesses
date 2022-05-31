using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessAuto.Data.Migrations
{
    public partial class RespondsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    studentId = table.Column<string>(nullable: true),
                    vacancyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responds_AspNetUsers_studentId",
                        column: x => x.studentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Responds_Vacancies_vacancyId",
                        column: x => x.vacancyId,
                        principalTable: "Vacancies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Responds_studentId",
                table: "Responds",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Responds_vacancyId",
                table: "Responds",
                column: "vacancyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responds");
        }
    }
}
