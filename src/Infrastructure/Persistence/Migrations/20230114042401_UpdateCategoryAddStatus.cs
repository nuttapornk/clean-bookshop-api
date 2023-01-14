using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategoryAddStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValueSql: "((1))");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeInsert",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeUpdate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "TimeInsert",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "TimeUpdate",
                table: "Category");
        }
    }
}
