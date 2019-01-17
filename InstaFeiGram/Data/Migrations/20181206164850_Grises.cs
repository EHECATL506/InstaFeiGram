using Microsoft.EntityFrameworkCore.Migrations;

namespace InstaFeiGram.Data.Migrations
{
    public partial class Grises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "grises",
                table: "Foto",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "grises",
                table: "Foto");
        }
    }
}
