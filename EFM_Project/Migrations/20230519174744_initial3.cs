﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EFM_Project.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Qte",
                table: "Quantity",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qte",
                table: "Quantity");
        }
    }
}
