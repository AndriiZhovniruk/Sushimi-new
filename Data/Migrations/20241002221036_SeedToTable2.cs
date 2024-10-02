using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sushimi.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedToTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.InsertData(
				table: "Dishes",
				columns: new[] { "Id", "Category", "Name", "Price", "Weight" },
				values: new object[,]
				{
					{ 30, "Snaks", "Chips", 100, 135 },
					{ 31, "Hot", "Ramen Spicy", 350, 145 },
				}
			);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.DeleteData(
				table: "Dishes",
				keyColumn: "Id",
				keyValue: 30);

			migrationBuilder.DeleteData(
				table: "Dishes",
				keyColumn: "Id",
				keyValue: 31);
		}
    }
}
