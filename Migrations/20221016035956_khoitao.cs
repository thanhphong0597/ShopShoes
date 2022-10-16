using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnTotNghiep.Migrations
{
    public partial class khoitao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenericShoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenericShoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GenericShoes_Categories_Category_ID",
                        column: x => x.Category_ID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecificShoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    GenericShoes_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificShoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecificShoes_GenericShoes_GenericShoes_ID",
                        column: x => x.GenericShoes_ID,
                        principalTable: "GenericShoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecificShoes_Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Colors_ID = table.Column<int>(type: "int", nullable: false),
                    SpecificShoes_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificShoes_Colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecificShoes_Colors_Color_Colors_ID",
                        column: x => x.Colors_ID,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecificShoes_Colors_SpecificShoes_SpecificShoes_ID",
                        column: x => x.SpecificShoes_ID,
                        principalTable: "SpecificShoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecificShoes_Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sizes_ID = table.Column<int>(type: "int", nullable: false),
                    SpecificShoes_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificShoes_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecificShoes_Sizes_Sizes_Sizes_ID",
                        column: x => x.Sizes_ID,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecificShoes_Sizes_SpecificShoes_SpecificShoes_ID",
                        column: x => x.SpecificShoes_ID,
                        principalTable: "SpecificShoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenericShoes_Category_ID",
                table: "GenericShoes",
                column: "Category_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificShoes_GenericShoes_ID",
                table: "SpecificShoes",
                column: "GenericShoes_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificShoes_Colors_Colors_ID",
                table: "SpecificShoes_Colors",
                column: "Colors_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificShoes_Colors_SpecificShoes_ID",
                table: "SpecificShoes_Colors",
                column: "SpecificShoes_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificShoes_Sizes_Sizes_ID",
                table: "SpecificShoes_Sizes",
                column: "Sizes_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificShoes_Sizes_SpecificShoes_ID",
                table: "SpecificShoes_Sizes",
                column: "SpecificShoes_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecificShoes_Colors");

            migrationBuilder.DropTable(
                name: "SpecificShoes_Sizes");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "SpecificShoes");

            migrationBuilder.DropTable(
                name: "GenericShoes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
