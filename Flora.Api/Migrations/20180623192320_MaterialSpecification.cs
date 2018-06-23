using Microsoft.EntityFrameworkCore.Migrations;

namespace Flora.Api.Migrations
{
    public partial class MaterialSpecification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    SpecificationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.SpecificationId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecification",
                columns: table => new
                {
                    MaterialId = table.Column<int>(nullable: false),
                    SpecificationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecification", x => new { x.MaterialId, x.SpecificationId });
                    table.ForeignKey(
                        name: "FK_MaterialSpecification_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecification_Specifications_SpecificationId",
                        column: x => x.SpecificationId,
                        principalTable: "Specifications",
                        principalColumn: "SpecificationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "Name" },
                values: new object[] { 1, "Gül" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "Name" },
                values: new object[] { 2, "Papatya" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "Name" },
                values: new object[] { 3, "Orkide" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "Name" },
                values: new object[] { 4, "Süslemeler" });

            migrationBuilder.InsertData(
                table: "Specifications",
                columns: new[] { "SpecificationId", "Name" },
                values: new object[] { 2, "Dikenli" });

            migrationBuilder.InsertData(
                table: "Specifications",
                columns: new[] { "SpecificationId", "Name" },
                values: new object[] { 1, "Çiçekli" });

            migrationBuilder.InsertData(
                table: "Specifications",
                columns: new[] { "SpecificationId", "Name" },
                values: new object[] { 3, "Yapraklı" });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "MaterialSpecification",
                columns: new[] { "MaterialId", "SpecificationId" },
                values: new object[] { 4, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecification_SpecificationId",
                table: "MaterialSpecification",
                column: "SpecificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialSpecification");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Specifications");
        }
    }
}
