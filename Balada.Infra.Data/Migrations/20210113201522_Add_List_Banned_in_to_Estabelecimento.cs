using Microsoft.EntityFrameworkCore.Migrations;

namespace Balada.Infra.Data.Migrations
{
    public partial class Add_List_Banned_in_to_Estabelecimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannedList",
                table: "Baladas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannedList",
                table: "Baladas");
        }
    }
}
