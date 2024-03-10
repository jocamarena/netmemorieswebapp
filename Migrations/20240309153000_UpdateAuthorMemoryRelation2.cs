using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuthorMemoryRelation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Memories_Authors_AuthorID",
                table: "Memories");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorID",
                table: "Memories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Jane Doe" }
                });

            migrationBuilder.InsertData(
                table: "Memories",
                columns: new[] { "ID", "AuthorID", "Date", "Description" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(2023, 3, 9), "First Memory" },
                    { 2, 2, new DateOnly(2023, 3, 9), "Second Memory" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Memories_Authors_AuthorID",
                table: "Memories",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Memories_Authors_AuthorID",
                table: "Memories");

            migrationBuilder.DeleteData(
                table: "Memories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Memories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorID",
                table: "Memories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Memories_Authors_AuthorID",
                table: "Memories",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
