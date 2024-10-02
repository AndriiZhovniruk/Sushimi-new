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

			migrationBuilder.CreateTable(
				name: "Dishes",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
					Weight = table.Column<int>(type: "int", nullable: false),
					Price = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Dish", x => x.Id);
				});

			migrationBuilder.InsertData(
				table: "Dishes",
				columns: new[] { "Id", "Category", "Name", "Price", "Weight" },
				values: new object[,]
				{
					{ 1, "Sushi", "California", 410, 300 },
					{ 2, "Sushi", "California with Tuna", 520, 290 },
					{ 3, "Sushi", "Enigma", 350, 300 },
					{ 4, "Sushi", "Sakura", 480, 290 },
					{ 5, "Sushi", "Felix with Crab", 380, 305 },
					{ 6, "Sushi", "Itachi", 390, 320 },
					{ 7, "Sushi", "Red Dragon", 530, 325 },
					{ 8, "Sushi", "Fiadelfia", 400, 320 },
					{ 9, "Sets", "set 1", 1035, 600 },
					{ 10, "Sets", "set 2", 1540, 895 },
					{ 11, "Sets", "set 3", 1265, 950 },
					{ 12, "Sets", "set 4", 3300, 2100 },
					{ 13, "Sets", "set 5", 2280, 1600 },
					{ 14, "Sets", "set 6", 1320, 650 },
					{ 15, "Hot", "Beef udon noodles", 169, 260 },
					{ 16, "Hot", "Funchoza with seafood", 245, 250 },
					{ 17, "Hot", "Unagi chicken with rice", 155, 280 },
					{ 18, "Hot", "Udon noodles with prawns", 245, 370 },
					{ 19, "Snaks", "Inari", 140, 65 },
					{ 20, "Snaks", "Sashimi", 480, 155 },
					{ 21, "Snaks", "Tatar", 360, 150 },
					{ 22, "Snaks", "Chuka", 230, 185 },
					{ 23, "Drinks", "Coca-Cola", 35, 5 },
					{ 24, "Drinks", "Fanta", 35, 5 },
					{ 25, "Drinks", "Sprite", 35, 5 },
					{ 26, "Drinks", "Dr-Pepper", 40, 5 },
					{ 27, "Drinks", "Morshinkska", 35, 5 },
					{ 28, "Drinks", "Juice", 50, 5 },
					{ 29, "Snaks", "Shrimp shiso kimchi", 245, 120 }
				}
			);
		}

		/// <inheritdoc /> 
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "Dishes",
				keyColumn: "Id",
				keyValue: 29);
			{
				migrationBuilder.DropTable(
					name: "Dishes");
			}
		}

	}
}
