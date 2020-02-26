using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class AddedForeignKeyConstraintToCarsReg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carRegs_Employee_Employee1id",
                table: "carRegs");

            migrationBuilder.DropForeignKey(
                name: "FK_carRegs_securityStaffs_SecurityStaff1id",
                table: "carRegs");

            migrationBuilder.DropIndex(
                name: "IX_carRegs_Employee1id",
                table: "carRegs");

            migrationBuilder.DropIndex(
                name: "IX_carRegs_SecurityStaff1id",
                table: "carRegs");

            migrationBuilder.DropColumn(
                name: "Employee",
                table: "carRegs");

            migrationBuilder.DropColumn(
                name: "Employee1id",
                table: "carRegs");

            migrationBuilder.DropColumn(
                name: "SecurityStaff",
                table: "carRegs");

            migrationBuilder.DropColumn(
                name: "SecurityStaff1id",
                table: "carRegs");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "carRegs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SecurityStaffId",
                table: "carRegs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_carRegs_EmployeeId",
                table: "carRegs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_carRegs_SecurityStaffId",
                table: "carRegs",
                column: "SecurityStaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_carRegs_Employee_EmployeeId",
                table: "carRegs",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_carRegs_securityStaffs_SecurityStaffId",
                table: "carRegs",
                column: "SecurityStaffId",
                principalTable: "securityStaffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carRegs_Employee_EmployeeId",
                table: "carRegs");

            migrationBuilder.DropForeignKey(
                name: "FK_carRegs_securityStaffs_SecurityStaffId",
                table: "carRegs");

            migrationBuilder.DropIndex(
                name: "IX_carRegs_EmployeeId",
                table: "carRegs");

            migrationBuilder.DropIndex(
                name: "IX_carRegs_SecurityStaffId",
                table: "carRegs");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "carRegs");

            migrationBuilder.DropColumn(
                name: "SecurityStaffId",
                table: "carRegs");

            migrationBuilder.AddColumn<int>(
                name: "Employee",
                table: "carRegs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Employee1id",
                table: "carRegs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecurityStaff",
                table: "carRegs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecurityStaff1id",
                table: "carRegs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_carRegs_Employee1id",
                table: "carRegs",
                column: "Employee1id");

            migrationBuilder.CreateIndex(
                name: "IX_carRegs_SecurityStaff1id",
                table: "carRegs",
                column: "SecurityStaff1id");

            migrationBuilder.AddForeignKey(
                name: "FK_carRegs_Employee_Employee1id",
                table: "carRegs",
                column: "Employee1id",
                principalTable: "Employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_carRegs_securityStaffs_SecurityStaff1id",
                table: "carRegs",
                column: "SecurityStaff1id",
                principalTable: "securityStaffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
