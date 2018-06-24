using Microsoft.EntityFrameworkCore.Migrations;

namespace Flora.Api.Migrations
{
    public partial class MaterialSpecificationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MaterialSpecification",
                keyColumns: new[] { "MaterialId", "SpecificationId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MaterialSpecification",
                keyColumns: new[] { "MaterialId", "SpecificationId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 3, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MaterialSpecification",
                keyColumns: new[] { "MaterialId", "SpecificationId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MaterialSpecification",
                keyColumns: new[] { "MaterialId", "SpecificationId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 3, 2 });
        }
    }
}
