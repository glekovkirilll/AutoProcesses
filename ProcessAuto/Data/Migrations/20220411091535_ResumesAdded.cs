using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessAuto.Data.Migrations
{
    public partial class ResumesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    studentId = table.Column<string>(nullable: true),
                    AboutYourself = table.Column<string>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    Stack = table.Column<string>(nullable: true),
                    WorkingExperience = table.Column<string>(nullable: true),
                    ProgrammingLanguages = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_AspNetUsers_studentId",
                        column: x => x.studentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_studentId",
                table: "Resumes",
                column: "studentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resumes");
        }
    }
}
