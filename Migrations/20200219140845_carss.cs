using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class carss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carss",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlateNo = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    color = table.Column<string>(nullable: true),
                    madeDate = table.Column<DateTime>(nullable: false),
                    boughtDate = table.Column<DateTime>(nullable: false),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carss", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "keyRegs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kid = table.Column<string>(nullable: true),
                    locke = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    color = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keyRegs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "materials",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mid = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    serialNo = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materials", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carss");

            migrationBuilder.DropTable(
                name: "keyRegs");

            migrationBuilder.DropTable(
                name: "materials");
        }
    }
}
