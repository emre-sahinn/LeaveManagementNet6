using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa1111-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "5531e14f-7a1a-4cb8-95b8-10eb5f6824e6", "ADMİNİSTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa2222-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "c4076e50-5728-4922-9394-fff6d24a949b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "159f009b-eebb-4d61-8045-e2b3a848d3b7", "AQAAAAEAACcQAAAAEDCTCl3aOq3aontidIOvHOgm9TnyyOqzCLqN+VjlZ5G+bRLaxYLeD798mICCkPjUtQ==", "cc704f85-82df-4854-9009-2150af3dbd2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cca35504-29fd-4017-b0ee-a6cabe5bb99c", "AQAAAAEAACcQAAAAEGDysCLPMckQPJTBwHGes0u9QTLtSGT1rdGouANOCX1kdi92o2BK9qo1W6pCYjYJwA==", "8e9c8588-adeb-4771-97c7-344862c93555" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa1111-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "5e1ee467-8314-4f4d-84c9-3e94da410054", "ADMINISTRATOR" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df164850-2c07-4714-80c4-7cec2780d950", "AQAAAAEAACcQAAAAEMV/uJ6X9a/NqBvLXJFyDws6Kj/5YFsSWKpDrN1czYI1cgiYU+6K5Kn5Af9uPXFv7w==", "440be599-cc36-4eb2-a757-63a5ae8d0a76" });
        }
    }
}
