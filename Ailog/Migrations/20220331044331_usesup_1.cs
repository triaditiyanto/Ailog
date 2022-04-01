using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ailog.Migrations
{
    public partial class usesup_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alamat",
                table: "Use",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alamat",
                table: "Use");
        }
    }
}
