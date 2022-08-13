using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aaaa1111-7294-4091-9482-dcd934b47cd1", "bc26fdfb-acb5-45a7-bfbb-f137007b16c3", "Administrator", "ADMINISTRATOR" },
                    { "aaaa2222-7294-4091-9482-dcd934b47cd1", "981e832a-0e07-427b-a921-942b2ed2ee22", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e6cd6279-7294-4091-9482-dcd934b47cd1", 0, "d85f42b1-1093-4d74-afb1-b043d6876707", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "emresahin@gmail.com", false, "System", "Admin", false, null, "EMRESAHIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEO/0EpIHv4pB/YinNil/TGV/d4gCBsv1h8GOHl7DBYFhZ5ZHKwTt0KNEwrylYpDi2g==", null, false, "c4ab93b2-f553-4ad5-9aed-0485d4841d3d", null, false, null },
                    { "e7cd6279-7294-4091-9482-dcd934b47cd1", 0, "2c107d5d-56b8-48b8-badf-a38b44d638c4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", false, "System", "User", false, null, "USER@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGY2dPaSt6BmE3rljbOwJ5t0Sx49a3bnBEKNR1+PmHzOvHIDKEmi2RqRleuHHWoruQ==", null, false, "7b91e7ad-cc50-4575-a432-b67b7a051ac5", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aaaa1111-7294-4091-9482-dcd934b47cd1", "e6cd6279-7294-4091-9482-dcd934b47cd1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aaaa2222-7294-4091-9482-dcd934b47cd1", "e7cd6279-7294-4091-9482-dcd934b47cd1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aaaa1111-7294-4091-9482-dcd934b47cd1", "e6cd6279-7294-4091-9482-dcd934b47cd1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aaaa2222-7294-4091-9482-dcd934b47cd1", "e7cd6279-7294-4091-9482-dcd934b47cd1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa1111-7294-4091-9482-dcd934b47cd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa2222-7294-4091-9482-dcd934b47cd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6cd6279-7294-4091-9482-dcd934b47cd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7cd6279-7294-4091-9482-dcd934b47cd1");
        }
    }
}
