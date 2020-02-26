using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class workerss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "employeeid",
            //    table: "Workerss",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Workerss_employeeid",
            //    table: "Workerss",
            //    column: "employeeid");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Workerss_Employee_employeeid",
            //    table: "Workerss",
            //    column: "employeeid",
            //    principalTable: "Employee",
            //    principalColumn: "id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Workerss_Employee_employeeid",
            //    table: "Workerss");

            //migrationBuilder.DropIndex(
            //    name: "IX_Workerss_employeeid",
            //    table: "Workerss");

            //migrationBuilder.DropColumn(
            //    name: "employeeid",
            //    table: "Workerss");
        }
    }
}
