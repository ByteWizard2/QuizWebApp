using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuizAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QnId", "Answer", "ImageName", "Option1", "Option2", "Option3", "Option4", "QnInWords" },
                values: new object[,]
                {
                    { 1, 3, null, "Hyper Trainer Marking Language", "Hyper Text Marketing Language", "Hyper Text Markup Language", "Hyper Text Markup Leveler", "What does HTML stand for?" },
                    { 2, 3, null, "ALU", "Memory", "CPU", "Control unit", "The brain of any computer system is" },
                    { 3, 2, null, "FORTRAN", "PROLOG", "C", "COBOL", "Which of the following computer languages is used for artificial intelligence?" },
                    { 4, 3, null, "Mathematical Mind", "Artistic mind", "Logical Mind", "Scientific Knowledge", "What is the primary requisite of a good computer programmer?" },
                    { 5, 3, "mouse.png", "Keyboard", "Monitor", "Mouse", "Graphics Card", "Name the device." },
                    { 6, 1, null, "Analytical Engine", "Calculator", "Processor", "Abacus", "The first mechanical computer designed by Charles Babbage was called?" },
                    { 7, 2, null, "4 bits", "8 bits", "16 bits", "32 bits", "One byte is equivalent to?" },
                    { 8, 3, null, "FTP", "UML", "HTML", "URL", "Web pages are written using?" },
                    { 9, 4, null, "Dos", "Unix", "Window NT", "CSS", "Which of the following is NOT an operating system?" },
                    { 10, 4, null, "Interface Program", "Interface Protocol", "Internet program", "Internet Protocol", "What is the full form of IP?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QnId",
                keyValue: 10);
        }
    }
}
