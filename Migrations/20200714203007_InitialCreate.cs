using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace freightWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Freight",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrokerName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Commodity = table.Column<string>(nullable: true),
                    Linehaul = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freight", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Freight");
        }
    }
}
