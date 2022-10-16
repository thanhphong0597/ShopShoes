using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnTotNghiep.Migrations
{
    public partial class khoitaoGener : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "GenericShoes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "GenericShoes",
                columns: new[] { "Id", "Category_ID", "Details", "Image", "Name" },
                values: new object[] { 1, 1, "...", null, "Nike so 1" });

            migrationBuilder.InsertData(
                table: "GenericShoes",
                columns: new[] { "Id", "Category_ID", "Details", "Image", "Name" },
                values: new object[] { 2, 1, "...", null, "Nike so 2" });

            migrationBuilder.InsertData(
                table: "GenericShoes",
                columns: new[] { "Id", "Category_ID", "Details", "Image", "Name" },
                values: new object[] { 3, 2, "...", null, "Joden so 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenericShoes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenericShoes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenericShoes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "GenericShoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
