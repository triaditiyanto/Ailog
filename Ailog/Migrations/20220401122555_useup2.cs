using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ailog.Migrations
{
    public partial class useup2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nomor_Karyawan",
                table: "Use",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nomor_Karyawan",
                table: "Use");
        }
    }
}
