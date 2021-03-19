using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_proj.Data.Migrations
{
    public partial class ChangedWeeklyPickupToForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_DaysOfTheWeek_WeeklyPickUpDayId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_WeeklyPickUpDayId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "487d4823-50f2-4e65-ad2a-d56b400d012f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1e282e7-e776-4b79-8799-43143bf5c8c6");

            migrationBuilder.AlterColumn<string>(
                name: "WeeklyPickUpDayId",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeeklyPickUpDayId1",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e409370f-9dfb-4a56-b74e-4a0c915353ef", "38bd450e-a3e3-40a8-a5f6-166b715dd2d3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecb13632-3cf2-410d-888c-053f9e683383", "9953a983-01f0-4d4c-9d3f-2d94bb4d7a54", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_WeeklyPickUpDayId1",
                table: "Customers",
                column: "WeeklyPickUpDayId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_DaysOfTheWeek_WeeklyPickUpDayId1",
                table: "Customers",
                column: "WeeklyPickUpDayId1",
                principalTable: "DaysOfTheWeek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_DaysOfTheWeek_WeeklyPickUpDayId1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_WeeklyPickUpDayId1",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e409370f-9dfb-4a56-b74e-4a0c915353ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecb13632-3cf2-410d-888c-053f9e683383");

            migrationBuilder.DropColumn(
                name: "WeeklyPickUpDayId1",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "WeeklyPickUpDayId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d1e282e7-e776-4b79-8799-43143bf5c8c6", "f5867ffa-f39f-4966-8899-3951690bdc27", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "487d4823-50f2-4e65-ad2a-d56b400d012f", "bc995617-85b7-4106-b4a7-775525f4f0b0", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_WeeklyPickUpDayId",
                table: "Customers",
                column: "WeeklyPickUpDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_DaysOfTheWeek_WeeklyPickUpDayId",
                table: "Customers",
                column: "WeeklyPickUpDayId",
                principalTable: "DaysOfTheWeek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
