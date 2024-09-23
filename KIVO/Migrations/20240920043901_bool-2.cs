﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KIVO.Migrations
{
    /// <inheritdoc />
    public partial class bool2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SelecionoPlan",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelecionoPlan",
                table: "AspNetUsers");
        }
    }
}
