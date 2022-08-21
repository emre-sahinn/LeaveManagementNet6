using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa1111-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "d69b273d-3e5f-4f9a-86df-c7c2084b44b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa2222-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "9184514b-9429-43fe-8af4-d3eb77fab574");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05adc970-02c5-4348-91d8-df7820dd3389", "AQAAAAEAACcQAAAAEEiBzWx3GW71zYsAl4MlNp0iyZePxFl3aaS7qsQUj478BAs0kwpP8zKpFJY4luYqmw==", "87b310bf-9f95-4dca-bcc8-6397ea821995" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82dcda7b-8efe-43b3-865a-b40e06360ded", "AQAAAAEAACcQAAAAEBf9Qmr5sy/+57jnMh6nIkdz0lX9ZM1XexLxK1ttfQFEYAP7GrS3xfhJV+emNj7aoA==", "e9c8372d-1a3a-4097-b572-d4e1fdbac61c" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa1111-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "5531e14f-7a1a-4cb8-95b8-10eb5f6824e6");

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
    }
}
