using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class changedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carRegs_Employee_EmployeeId",
                table: "carRegs");

            migrationBuilder.DropForeignKey(
                name: "FK_carRegs_securityStaffs_SecurityStaffId",
                table: "carRegs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carRegs",
                table: "carRegs");

            migrationBuilder.RenameTable(
                name: "carRegs",
                newName: "CarRegs");

            migrationBuilder.RenameIndex(
                name: "IX_carRegs_SecurityStaffId",
                table: "CarRegs",
                newName: "IX_CarRegs_SecurityStaffId");

            migrationBuilder.RenameIndex(
                name: "IX_carRegs_EmployeeId",
                table: "CarRegs",
                newName: "IX_CarRegs_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarRegs",
                table: "CarRegs",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarRegs_Employee_EmployeeId",
                table: "CarRegs",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarRegs_securityStaffs_SecurityStaffId",
                table: "CarRegs",
                column: "SecurityStaffId",
                principalTable: "securityStaffs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarRegs_Employee_EmployeeId",
                table: "CarRegs");

            migrationBuilder.DropForeignKey(
                name: "FK_CarRegs_securityStaffs_SecurityStaffId",
                table: "CarRegs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarRegs",
                table: "CarRegs");

            migrationBuilder.RenameTable(
                name: "CarRegs",
                newName: "carRegs");

            migrationBuilder.RenameIndex(
                name: "IX_CarRegs_SecurityStaffId",
                table: "carRegs",
                newName: "IX_carRegs_SecurityStaffId");

            migrationBuilder.RenameIndex(
                name: "IX_CarRegs_EmployeeId",
                table: "carRegs",
                newName: "IX_carRegs_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carRegs",
                table: "carRegs",
                column: "id");

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
    }
}
