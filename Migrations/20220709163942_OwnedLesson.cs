﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreMovies.Migrations
{
    public partial class OwnedLesson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Country",
                table: "Cinemas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Province",
                table: "Cinemas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Cinemas",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillingAddress_Country",
                table: "Actors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillingAddress_Province",
                table: "Actors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BillingAddress_Street",
                table: "Actors",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeAddress_Country",
                table: "Actors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeAddress_Province",
                table: "Actors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Street",
                table: "Actors",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Country",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Province",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "BillingAddress_Street",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Country",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Province",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Street",
                table: "Actors");
        }
    }
}
