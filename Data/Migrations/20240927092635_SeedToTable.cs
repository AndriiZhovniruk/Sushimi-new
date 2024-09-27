using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sushimi.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "Category", "Name", "Price", "Weight" },
                values: new object[] { 29, "Snaks", "Shrimp shiso kimchi", 245, 120 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 29);
        }
    }
}
