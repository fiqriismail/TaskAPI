using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class JobRoleFieldAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Systems Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 17, 1, 438, DateTimeKind.Local).AddTicks(251), new DateTime(2021, 7, 16, 14, 17, 1, 438, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 17, 1, 438, DateTimeKind.Local).AddTicks(7970), new DateTime(2021, 7, 16, 14, 17, 1, 438, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 17, 1, 438, DateTimeKind.Local).AddTicks(7980), new DateTime(2021, 7, 16, 14, 17, 1, 438, DateTimeKind.Local).AddTicks(7981) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 6, 12, 22, 1, 52, 413, DateTimeKind.Local).AddTicks(1857), new DateTime(2021, 6, 17, 22, 1, 52, 414, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 6, 12, 22, 1, 52, 414, DateTimeKind.Local).AddTicks(3722), new DateTime(2021, 6, 17, 22, 1, 52, 414, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 6, 12, 22, 1, 52, 414, DateTimeKind.Local).AddTicks(3735), new DateTime(2021, 6, 17, 22, 1, 52, 414, DateTimeKind.Local).AddTicks(3736) });
        }
    }
}
