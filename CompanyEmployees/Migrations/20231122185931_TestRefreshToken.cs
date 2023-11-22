using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class TestRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "874f27bf-b15b-410d-9a1b-adf0f360ace4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb56c861-57e6-4d16-9109-9e206b9ea227");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4113719f-02fb-4fb5-8baf-da89cf8381c9", null, "Administrator", "ADMINISTRATOR" },
                    { "9f926476-6463-4ffd-a670-f825cd625b2c", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4113719f-02fb-4fb5-8baf-da89cf8381c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f926476-6463-4ffd-a670-f825cd625b2c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "874f27bf-b15b-410d-9a1b-adf0f360ace4", null, "Administrator", "ADMINISTRATOR" },
                    { "cb56c861-57e6-4d16-9109-9e206b9ea227", null, "Manager", "MANAGER" }
                });
        }
    }
}
