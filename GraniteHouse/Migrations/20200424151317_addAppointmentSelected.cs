using Microsoft.EntityFrameworkCore.Migrations;

namespace GraniteHouse.Migrations
{
    public partial class addAppointmentSelected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SalesPersonId",
                table: "Appointments",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SalesPersonId",
                table: "Appointments",
                column: "SalesPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_SalesPersonId",
                table: "Appointments",
                column: "SalesPersonId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_SalesPersonId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_SalesPersonId",
                table: "Appointments");

            migrationBuilder.AlterColumn<string>(
                name: "SalesPersonId",
                table: "Appointments",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
