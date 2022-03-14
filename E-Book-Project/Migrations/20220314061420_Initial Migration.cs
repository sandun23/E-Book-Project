using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Book_Project.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<string>(nullable: false),
                    BookName = table.Column<string>(nullable: true),
                    BookAuthorName = table.Column<string>(nullable: true),
                    BookPrice = table.Column<string>(nullable: true),
                    Created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
