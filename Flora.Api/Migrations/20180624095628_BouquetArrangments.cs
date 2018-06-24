using Microsoft.EntityFrameworkCore.Migrations;

namespace Flora.Api.Migrations
{
    public partial class BouquetArrangments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 1, 1, 10, 1 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 16, 7, 1, 3 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 15, 6, 1, 4 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 14, 6, 20, 2 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 13, 6, 10, 1 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 12, 5, 1, 4 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 11, 5, 20, 2 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 10, 5, 7, 1 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 9, 4, 1, 4 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 8, 4, 20, 2 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 7, 4, 5, 1 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 6, 3, 1, 4 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 5, 3, 50, 1 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 4, 2, 1, 4 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 3, 2, 25, 1 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 2, 1, 1, 4 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 17, 8, 2, 3 });

            migrationBuilder.InsertData(
                table: "Arrangement",
                columns: new[] { "ArrangmentId", "BouquetDetailId", "MaterialCount", "MaterialId" },
                values: new object[] { 18, 9, 5, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Arrangement",
                keyColumn: "ArrangmentId",
                keyValue: 18);
        }
    }
}
