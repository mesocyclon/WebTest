using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebTest.Migrations
{
    public partial class u : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "phonelink",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phonelink", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "phone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_phone_phonelink_PhoneLinkId",
                        column: x => x.PhoneLinkId,
                        principalTable: "phonelink",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_phonelink_PhoneLinkId",
                        column: x => x.PhoneLinkId,
                        principalTable: "phonelink",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_phone_PhoneLinkId",
                table: "phone",
                column: "PhoneLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_users_PhoneLinkId",
                table: "users",
                column: "PhoneLinkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "phone");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "phonelink");
        }
    }
}
