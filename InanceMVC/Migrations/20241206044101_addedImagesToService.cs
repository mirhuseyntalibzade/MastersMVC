﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InanceMVC.Migrations
{
    /// <inheritdoc />
    public partial class addedImagesToService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Services");
        }
    }
}
