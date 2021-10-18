﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class _rt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ou = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Fu", "Iu", "Ou" },
                values: new object[] { new Guid("30fb2dd3-ea0e-4f05-b0db-ef6341a593f0"), "В космос ", "text text", "text text text" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
