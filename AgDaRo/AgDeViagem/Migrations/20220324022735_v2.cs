using Microsoft.EntityFrameworkCore.Migrations;

namespace AgDeViagem.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgPassagem",
                table: "passagens",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgPassagem",
                table: "passagens");
        }
    }
}
