using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApi.API.Migrations
{
    public partial class SeededDefaultUserandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d58b369-5b5c-4a8c-be13-06afc5d26d6e", "4315d39c-bc06-4252-88a2-b1fd90a7cec9", "Administrator", "ADMINISTRATOR" },
                    { "50f0ba10-8b59-4286-b019-7eea16ac603f", "0ee487fd-ff94-4ba9-bdc2-5f17a0e85fbb", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "53256e45-7eaa-4e4a-899b-74b36a40362e", 0, "bbfd310a-32da-4cd3-9099-51b4e73f3a3a", "user@booksstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAECJI+pqw8QPybqaWh4F8QN9c+qLkw6SBeWydtR00iaMCKCZmmwkisb9xPEKCII1aew==", null, false, "2631d696-883a-4594-ae28-c27ec2d1df07", false, "user@bookstore.com" },
                    { "58f72d08-555c-47ab-8c8e-4ea6be4216ad", 0, "5894656c-4b79-40d5-87fc-9d21217bd7f8", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAELKfLX9Mnawv3qZoKDQPT65ypv1ttXLLSGXHyesf+AIb/Lkz4Pj7X96tsNskfrtaEg==", null, false, "8a7a14eb-36d9-4c3b-b2a6-c652ecf8d0c2", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "50f0ba10-8b59-4286-b019-7eea16ac603f", "53256e45-7eaa-4e4a-899b-74b36a40362e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0d58b369-5b5c-4a8c-be13-06afc5d26d6e", "58f72d08-555c-47ab-8c8e-4ea6be4216ad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50f0ba10-8b59-4286-b019-7eea16ac603f", "53256e45-7eaa-4e4a-899b-74b36a40362e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d58b369-5b5c-4a8c-be13-06afc5d26d6e", "58f72d08-555c-47ab-8c8e-4ea6be4216ad" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d58b369-5b5c-4a8c-be13-06afc5d26d6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50f0ba10-8b59-4286-b019-7eea16ac603f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53256e45-7eaa-4e4a-899b-74b36a40362e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58f72d08-555c-47ab-8c8e-4ea6be4216ad");
        }
    }
}
