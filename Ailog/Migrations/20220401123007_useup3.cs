using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ailog.Migrations
{
    public partial class useup3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Job_Desk",
                table: "Use",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Job_Desk",
                table: "Use");
        }
    }
}
