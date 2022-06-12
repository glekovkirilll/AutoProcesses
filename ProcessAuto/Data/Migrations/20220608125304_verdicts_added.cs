using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessAuto.Data.Migrations
{
    public partial class verdicts_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentsVerdict",
                table: "Responds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VacancyStage",
                table: "Responds",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentsVerdict",
                table: "Responds");

            migrationBuilder.DropColumn(
                name: "VacancyStage",
                table: "Responds");
        }
    }
}
