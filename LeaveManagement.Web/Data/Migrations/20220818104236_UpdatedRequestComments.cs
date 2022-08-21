using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa1111-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "51ec57ea-a735-489c-9968-5ee21dbc36e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaaa2222-7294-4091-9482-dcd934b47cd1",
                column: "ConcurrencyStamp",
                value: "5d99c1f2-5b12-4ee3-9871-70c362666869");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a60e9691-d07b-4552-9ed8-b6173440f3b9", "AQAAAAEAACcQAAAAEOHNykD6xO4KJDMe/xvZ0Jd0cXWw/p7ihVYOyWiqxxi3nd5rpkCv5i678EoTqz3OLg==", "ebb5ab6e-2727-46ad-a0ca-05f19203d84e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7cd6279-7294-4091-9482-dcd934b47cd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b000524-8425-49dc-8e7b-402be404b6f8", "AQAAAAEAACcQAAAAEM18tYtDi9pXN6p0grPUx5teElCw3R1+tszr8QfRQBXPQ9cZ21aMSE7IcqZ5z8KSvA==", "747432d7-dae1-4bc0-bb6e-ae50d746b488" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
