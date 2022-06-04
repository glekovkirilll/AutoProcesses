using Microsoft.EntityFrameworkCore.Migrations;

namespace ProcessAuto.Data.Migrations
{
    public partial class company_id_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Vacancies",
                nullable: false,
                defaultValue: 0);
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {            

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Vacancies");
        }
    }
}
