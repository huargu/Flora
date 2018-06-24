using Microsoft.EntityFrameworkCore.Migrations;

namespace Flora.Api.Migrations
{
    public partial class BouquetAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bouquet",
                columns: table => new
                {
                    BouquetId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bouquet", x => x.BouquetId);
                });

            migrationBuilder.CreateTable(
                name: "BouquetDetail",
                columns: table => new
                {
                    DetailId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Size = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    BouquetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BouquetDetail", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_BouquetDetail_Bouquet_BouquetId",
                        column: x => x.BouquetId,
                        principalTable: "Bouquet",
                        principalColumn: "BouquetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arrangement",
                columns: table => new
                {
                    ArrangmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaterialId = table.Column<int>(nullable: false),
                    MaterialCount = table.Column<int>(nullable: false),
                    BouquetDetailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arrangement", x => x.ArrangmentId);
                    table.ForeignKey(
                        name: "FK_Arrangement_BouquetDetail_BouquetDetailId",
                        column: x => x.BouquetDetailId,
                        principalTable: "BouquetDetail",
                        principalColumn: "DetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arrangement_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bouquet",
                columns: new[] { "BouquetId", "Name" },
                values: new object[] { 1, "Gül Bahçesi" });

            migrationBuilder.InsertData(
                table: "Bouquet",
                columns: new[] { "BouquetId", "Name" },
                values: new object[] { 2, "Gelinlikli Güller" });

            migrationBuilder.InsertData(
                table: "Bouquet",
                columns: new[] { "BouquetId", "Name" },
                values: new object[] { 3, "Orkide" });

            migrationBuilder.InsertData(
                table: "BouquetDetail",
                columns: new[] { "DetailId", "BouquetId", "Price", "Size" },
                values: new object[] { 1, 1, 10m, "S" });

            migrationBuilder.InsertData(
                table: "BouquetDetail",
                columns: new[] { "DetailId", "BouquetId", "Price", "Size" },
                values: new object[] { 2, 1, 15m, "M" });

            migrationBuilder.InsertData(
                table: "BouquetDetail",
                columns: new[] { "DetailId", "BouquetId", "Price", "Size" },
                values: new object[] { 3, 1, 20m, "L" });

            migrationBuilder.InsertData(
                table: "BouquetDetail",
                columns: new[] { "DetailId", "BouquetId", "Price", "Size" },
                values: new object[] { 4, 2, 12m, "S" });

            migrationBuilder.InsertData(
                table: "BouquetDetail",
                columns: new[] { "DetailId", "BouquetId", "Price", "Size" },
                values: new object[] { 5, 2, 16m, "M" });

            migrationBuilder.InsertData(
                table: "BouquetDetail",
                columns: new[] { "DetailId", "BouquetId", "Price", "Size" },
                values: new object[] { 6, 2, 20m, "L" });

            migrationBuilder.InsertData(
                table: "BouquetDetail",
                columns: new[] { "DetailId", "BouquetId", "Price", "Size" },
                values: new object[] { 7, 3, 20m, "S" });

            migrationBuilder.InsertData(
                table: "BouquetDetail",
                columns: new[] { "DetailId", "BouquetId", "Price", "Size" },
                values: new object[] { 8, 3, 25m, "M" });

            migrationBuilder.InsertData(
                table: "BouquetDetail",
                columns: new[] { "DetailId", "BouquetId", "Price", "Size" },
                values: new object[] { 9, 3, 30m, "L" });

            migrationBuilder.CreateIndex(
                name: "IX_Arrangement_BouquetDetailId",
                table: "Arrangement",
                column: "BouquetDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Arrangement_MaterialId",
                table: "Arrangement",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_BouquetDetail_BouquetId",
                table: "BouquetDetail",
                column: "BouquetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arrangement");

            migrationBuilder.DropTable(
                name: "BouquetDetail");

            migrationBuilder.DropTable(
                name: "Bouquet");
        }
    }
}
