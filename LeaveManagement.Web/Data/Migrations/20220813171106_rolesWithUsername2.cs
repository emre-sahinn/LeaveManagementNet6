using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class rolesWithUsername2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa1111-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "5e1ee467-8314-4f4d-84c9-3e94da410054");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa2222-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "787627d3-30a4-4178-863b-96a1ab01ae59");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "028b540d-24a6-46fc-a6b3-bc52dbd2da18", "AQAAAAEAACcQAAAAEHtfOqiTfISikCHFjaVYxo/lolMwLKccUClc4oXvHSYKtUrTodRtiQg3sE0Xq6XXcA==", "30317b47-6aa2-4627-95de-9ce51fcab8c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "df164850-2c07-4714-80c4-7cec2780d950", "AQAAAAEAACcQAAAAEMV/uJ6X9a/NqBvLXJFyDws6Kj/5YFsSWKpDrN1czYI1cgiYU+6K5Kn5Af9uPXFv7w==", "440be599-cc36-4eb2-a757-63a5ae8d0a76", "user@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8820ed2a-3803-4032-ba0d-d74291a3649d", "AQAAAAEAACcQAAAAEOWoEWZJwjQ/D4wXHXo45e4rktvfMwdmOXb5yc5NMStENj0l2Ktmep1oNUOgBnD7GA==", "5e3f0eba-1fdf-42d7-b8f4-8663205e7352" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "680566bb-8b6a-46d2-ab64-56c93c9a9443", "AQAAAAEAACcQAAAAECOf77WlqCE8OhHqMFum0np8coRlxAcLLxNa2GpoHadMmSzXhFWxQBEzM8lGzbbmXw==", "ff19d9ac-6640-4fc2-9489-17448faf8e83", null });
        }
    }
}
