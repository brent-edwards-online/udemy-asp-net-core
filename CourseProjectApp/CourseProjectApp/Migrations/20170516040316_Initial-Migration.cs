using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProjectApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Register",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Register", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Register");
        }
    }
}
