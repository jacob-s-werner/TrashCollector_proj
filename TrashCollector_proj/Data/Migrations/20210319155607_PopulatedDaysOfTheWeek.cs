using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_proj.Data.Migrations
{
    public partial class PopulatedDaysOfTheWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77831160-938c-4862-ad11-a889f012d85b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9edaaaf7-9c4f-40ff-b448-f8925f70b87a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bebb061e-e2f9-45c4-8dba-d13e1b87d0ef");

            migrationBuilder.DropColumn(
                name: "WeeklyPickUpDay",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "WeeklyPickUpDayId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DaysOfTheWeek",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysOfTheWeek", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d1e282e7-e776-4b79-8799-43143bf5c8c6", "f5867ffa-f39f-4966-8899-3951690bdc27", "Customer", "CUSTOMER" },
                    { "487d4823-50f2-4e65-ad2a-d56b400d012f", "bc995617-85b7-4106-b4a7-775525f4f0b0", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "DaysOfTheWeek",
                columns: new[] { "Id", "Day" },
                values: new object[,]
                {
                    { 1, "Sunday" },
                    { 2, "Monday" },
                    { 3, "Tuesday" },
                    { 4, "Wednesday" },
                    { 5, "Thursday" },
                    { 6, "Friday" },
                    { 7, "Saturday" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_DaysOfTheWeek_WeeklyPickUpDayId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "DaysOfTheWeek");

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

            migrationBuilder.DropColumn(
                name: "WeeklyPickUpDayId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "WeeklyPickUpDay",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bebb061e-e2f9-45c4-8dba-d13e1b87d0ef", "976fa7c4-aa30-4b0a-856f-2f5598344abe", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9edaaaf7-9c4f-40ff-b448-f8925f70b87a", "26c2454b-6e1b-414a-a58a-6f841509ded7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77831160-938c-4862-ad11-a889f012d85b", "511a1c75-fb64-4b37-bf9b-c7ad8ddc9dba", "Employee", "EMPLOYEE" });
        }
    }
}
