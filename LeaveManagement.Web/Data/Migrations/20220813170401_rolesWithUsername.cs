using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class rolesWithUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa1111-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "636d5a6e-448d-48b2-94b0-20ae23978d1f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa2222-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "eadf8d47-93f8-4c6b-ad20-189c13217ccf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8820ed2a-3803-4032-ba0d-d74291a3649d", true, "EMRESAHIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOWoEWZJwjQ/D4wXHXo45e4rktvfMwdmOXb5yc5NMStENj0l2Ktmep1oNUOgBnD7GA==", "5e3f0eba-1fdf-42d7-b8f4-8663205e7352", "emresahin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "680566bb-8b6a-46d2-ab64-56c93c9a9443", true, "USER@GMAIL.COM", "AQAAAAEAACcQAAAAECOf77WlqCE8OhHqMFum0np8coRlxAcLLxNa2GpoHadMmSzXhFWxQBEzM8lGzbbmXw==", "ff19d9ac-6640-4fc2-9489-17448faf8e83" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa1111-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "bc26fdfb-acb5-45a7-bfbb-f137007b16c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa2222-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "981e832a-0e07-427b-a921-942b2ed2ee22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d85f42b1-1093-4d74-afb1-b043d6876707", false, null, "AQAAAAEAACcQAAAAEO/0EpIHv4pB/YinNil/TGV/d4gCBsv1h8GOHl7DBYFhZ5ZHKwTt0KNEwrylYpDi2g==", "c4ab93b2-f553-4ad5-9aed-0485d4841d3d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c107d5d-56b8-48b8-badf-a38b44d638c4", false, null, "AQAAAAEAACcQAAAAEGY2dPaSt6BmE3rljbOwJ5t0Sx49a3bnBEKNR1+PmHzOvHIDKEmi2RqRleuHHWoruQ==", "7b91e7ad-cc50-4575-a432-b67b7a051ac5" });
        }
    }
}
