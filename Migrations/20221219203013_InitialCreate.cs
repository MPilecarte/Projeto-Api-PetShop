using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiPetShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Porte = table.Column<int>(type: "int", nullable: false),
                    Idade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    RGA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUltVacina = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicoPrestado = table.Column<int>(type: "int", nullable: false),
                    ValorServico = table.Column<float>(type: "real", nullable: false),
                    DataAgendada = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TutorAnimais",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NroCasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorAnimais", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Animais",
                columns: new[] { "id", "DataUltVacina", "Especie", "Genero", "Idade", "Nome", "Porte", "RGA" },
                values: new object[,]
                {
                    { 1, "20-02-2022", "Cão", 2, "2 anos", "Yotan", 3, "31-121-995" },
                    { 2, "05-09-2022", "Cão", 2, "7 meses", "RapMon", 3, "12-091-994" },
                    { 3, "13-05-2022", "Cão", 2, "3 meses", "Geurem", 2, "01-091-997" },
                    { 4, "07-12-2022", "Cão", 2, "5 anos", "Mickey", 1, "18-021-994" },
                    { 5, "03-04-2022", "Cão", 1, "1 ano", "Holly", 1, "04-121-992" },
                    { 6, "19-08-2022", "Gato", 2, "4 meses", "Curry", 1, "13-121-995" },
                    { 7, "25-03-2022", "Petauro-do-açucar", 2, "2 anos", "Odeg", 1, "04-121-992" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "TutorAnimais");
        }
    }
}
