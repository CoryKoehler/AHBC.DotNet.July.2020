using Microsoft.EntityFrameworkCore.Migrations;

namespace October22ndEFCoreCodeFirst.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prodcuts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodcuts", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Prodcuts",
                columns: new[] { "ID", "Category", "Name" },
                values: new object[] { 1, "Sports", "Basketball" });

            migrationBuilder.InsertData(
                table: "Prodcuts",
                columns: new[] { "ID", "Category", "Name" },
                values: new object[] { 2, "Sports", "Baseball Bat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prodcuts");
        }
    }
}
