using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector_proj.Data.Migrations
{
    public partial class testt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChargesToCustomers_Customers_CustomerId",
                table: "ChargesToCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_OneTimePickups_Customers_CustomerId",
                table: "OneTimePickups");

            migrationBuilder.DropForeignKey(
                name: "FK_TempPickUpSuspensions_Customers_CustomerId",
                table: "TempPickUpSuspensions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c58af4c-d5a1-4bc1-bf03-9b1ffe9c0719");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "812f8787-5434-4869-995b-80e3a2ad1394");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b46c5ad6-deab-483e-9571-6980c84c7493");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customer",
                newName: "IX_Customer_IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_AddressId",
                table: "Customer",
                newName: "IX_Customer_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37025ffa-cf73-4569-b53a-e6d5f9568875", "199a614c-09b5-4322-a66c-d5ec3f6dd878", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e680e869-6596-4799-8f0a-7c99b5446f36", "daf1ad4e-d850-43f6-a259-a0c89db98563", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6bd738f-559a-46d2-917d-7ad1143f633d", "8eaa5c23-6d0a-45dd-939c-c04b9d4554ff", "Employee", "EMPLOYEE" });

            migrationBuilder.AddForeignKey(
                name: "FK_ChargesToCustomers_Customer_CustomerId",
                table: "ChargesToCustomers",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Addresses_AddressId",
                table: "Customer",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OneTimePickups_Customer_CustomerId",
                table: "OneTimePickups",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TempPickUpSuspensions_Customer_CustomerId",
                table: "TempPickUpSuspensions",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChargesToCustomers_Customer_CustomerId",
                table: "ChargesToCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Addresses_AddressId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_OneTimePickups_Customer_CustomerId",
                table: "OneTimePickups");

            migrationBuilder.DropForeignKey(
                name: "FK_TempPickUpSuspensions_Customer_CustomerId",
                table: "TempPickUpSuspensions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37025ffa-cf73-4569-b53a-e6d5f9568875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6bd738f-559a-46d2-917d-7ad1143f633d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e680e869-6596-4799-8f0a-7c99b5446f36");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customers",
                newName: "IX_Customers_IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_AddressId",
                table: "Customers",
                newName: "IX_Customers_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "812f8787-5434-4869-995b-80e3a2ad1394", "2460a1b1-b489-493a-a446-cda30d120273", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c58af4c-d5a1-4bc1-bf03-9b1ffe9c0719", "c001a65f-5e5e-4d1a-9e54-f033bbb4ff35", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b46c5ad6-deab-483e-9571-6980c84c7493", "e4bbe267-1ac5-41d5-9c88-a9f88552963b", "Employee", "EMPLOYEE" });

            migrationBuilder.AddForeignKey(
                name: "FK_ChargesToCustomers_Customers_CustomerId",
                table: "ChargesToCustomers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OneTimePickups_Customers_CustomerId",
                table: "OneTimePickups",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TempPickUpSuspensions_Customers_CustomerId",
                table: "TempPickUpSuspensions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
