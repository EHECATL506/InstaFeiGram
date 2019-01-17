using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InstaFeiGram.Data.Migrations
{
    public partial class Subirfotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foto",
                columns: table => new
                {
                    idfoto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    rutaimagen = table.Column<string>(nullable: true),
                    titulo = table.Column<string>(nullable: false),
                    resumen = table.Column<string>(nullable: true),
                    tag = table.Column<string>(nullable: false),
                    fechasubida = table.Column<DateTime>(nullable: false),
                    numvisitas = table.Column<int>(nullable: false),
                    correousuario = table.Column<string>(nullable: true),
                    gusta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foto", x => x.idfoto);
                });

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    idcomentario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    texto = table.Column<string>(nullable: true),
                    correousuario = table.Column<string>(nullable: true),
                    imgdatosidfoto = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.idcomentario);
                    table.ForeignKey(
                        name: "FK_Comentario_Foto_imgdatosidfoto",
                        column: x => x.imgdatosidfoto,
                        principalTable: "Foto",
                        principalColumn: "idfoto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_imgdatosidfoto",
                table: "Comentario",
                column: "imgdatosidfoto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Foto");
        }
    }
}
