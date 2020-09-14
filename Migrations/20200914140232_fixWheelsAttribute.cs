using Microsoft.EntityFrameworkCore.Migrations;

namespace CarManagementSystem.Migrations
{
    public partial class fixWheelsAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Wheels",
                table: "Car",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1,
                column: "Wheels",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2,
                column: "Wheels",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 3,
                column: "Wheels",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wheels",
                table: "Car");
        }
    }
}
