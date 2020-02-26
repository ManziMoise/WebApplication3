using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class CarRegs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carRegs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(nullable: false),
                    Employee = table.Column<int>(nullable: true),
                    plateNo = table.Column<string>(nullable: true),
                    timein = table.Column<DateTime>(nullable: false),
                    timeout = table.Column<DateTime>(nullable: false),
                    SecurityStaff = table.Column<int>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    Employee1id = table.Column<int>(nullable: true),
                    SecurityStaff1id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carRegs", x => x.id);
                    table.ForeignKey(
                        name: "FK_carRegs_Employee_Employee1id",
                        column: x => x.Employee1id,
                        principalTable: "Employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_carRegs_securityStaffs_SecurityStaff1id",
                        column: x => x.SecurityStaff1id,
                        principalTable: "securityStaffs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carRegs_Employee1id",
                table: "carRegs",
                column: "Employee1id");

            migrationBuilder.CreateIndex(
                name: "IX_carRegs_SecurityStaff1id",
                table: "carRegs",
                column: "SecurityStaff1id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carRegs");
        }
    }
}
