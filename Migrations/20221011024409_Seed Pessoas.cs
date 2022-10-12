using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIGNA.Migrations
{
    public partial class SeedPessoas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "PESSOA_ID", "NOME_FANTASIA", "CNPJ_CPF" },
                values: new object[,]
                {
                    { 1, "Vitor Lacerda Faria", "16520562700" },
                    { 2, "João das Couves", "01234567890" },
                    { 3, "Maria das Couves", "09876543210" },
                    { 4, "Pedro Nascimento", "67890123456" },
                    { 5, "Nome Fantasia", "24964914000152" },
                    { 6, "John Doe", "45678901000143" },
                    { 7, "Steve Jobs", "87654321098" },
                    { 8, "Mark Zukerberg", "45678909876" },
                    { 9, "Elon Musk", "23456789087" },
                    { 10, "Microsoft Corp", "12654345000142" },
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
