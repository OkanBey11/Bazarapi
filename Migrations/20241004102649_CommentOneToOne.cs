using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class CommentOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "417a282a-3f07-4a41-86f9-16eb566624fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4566c8c-e0bb-4f6b-99ec-d45d3b4d2dd4");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Commenst",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d0f725b-a3e0-4d22-b9fc-5c7cc4445c93", null, "User", "USER" },
                    { "b53f7c6b-2808-46e7-9b05-a12c58510e19", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commenst_AppUserId",
                table: "Commenst",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commenst_AspNetUsers_AppUserId",
                table: "Commenst",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commenst_AspNetUsers_AppUserId",
                table: "Commenst");

            migrationBuilder.DropIndex(
                name: "IX_Commenst_AppUserId",
                table: "Commenst");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d0f725b-a3e0-4d22-b9fc-5c7cc4445c93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b53f7c6b-2808-46e7-9b05-a12c58510e19");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Commenst");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "417a282a-3f07-4a41-86f9-16eb566624fd", null, "User", "USER" },
                    { "e4566c8c-e0bb-4f6b-99ec-d45d3b4d2dd4", null, "Admin", "ADMIN" }
                });
        }
    }
}
