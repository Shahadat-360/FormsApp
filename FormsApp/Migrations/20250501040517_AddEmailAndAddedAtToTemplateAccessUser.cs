﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FormsApp.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailAndAddedAtToTemplateAccessUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedAt",
                table: "TemplateAccessUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TemplateAccessUser",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedAt",
                table: "TemplateAccessUser");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TemplateAccessUser");
        }
    }
}
