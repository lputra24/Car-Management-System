using Microsoft.EntityFrameworkCore.Migrations;

namespace CarManagementSystem.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VehicleType",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "car" });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "BodyType", "Doors", "Engine", "Make", "Model", "VehicleTypeId" },
                values: new object[] { 1, "sedan", 4, "2.0T Petrol 8 sp Automatic RWD", "alfa romeo", "veloce", 1 });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "BodyType", "Doors", "Engine", "Make", "Model", "VehicleTypeId" },
                values: new object[] { 2, "suv", 5, "2.0DT Diesel 8 sp Automatic 4x4", "hyundai", "active", 1 });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "BodyType", "Doors", "Engine", "Make", "Model", "VehicleTypeId" },
                values: new object[] { 3, "hatch", 5, "1.0T Petrol 5 sp Manual FWD", "volkswagen", "70tsi trendline", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VehicleType",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
