using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoDashboard.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "AnnouncementId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "PublishDate" },
                values: new object[] { new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 4, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "ProjectMembers",
                keyColumn: "ProjectMemberId",
                keyValue: 1,
                column: "AssignedDate",
                value: new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "ProjectMembers",
                keyColumn: "ProjectMemberId",
                keyValue: 2,
                column: "AssignedDate",
                value: new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate", "TargetCompletionDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 4, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 4, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DueDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 6, 14, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 4, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "AnnouncementId",
                keyValue: 1,
                columns: new[] { "ExpiryDate", "PublishDate" },
                values: new object[] { new DateTime(2026, 7, 3, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(7992), new DateTime(2026, 6, 3, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "ProjectMembers",
                keyColumn: "ProjectMemberId",
                keyValue: 1,
                column: "AssignedDate",
                value: new DateTime(2026, 5, 4, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "ProjectMembers",
                keyColumn: "ProjectMemberId",
                keyValue: 2,
                column: "AssignedDate",
                value: new DateTime(2026, 5, 4, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "StartDate", "TargetCompletionDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 4, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(3750), new DateTime(2026, 5, 4, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(3119), new DateTime(2026, 8, 2, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(3376), new DateTime(2026, 6, 3, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 4, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(5732), new DateTime(2026, 5, 14, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(5214), new DateTime(2026, 5, 14, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 9, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(5952), new DateTime(2026, 6, 8, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(5950), new DateTime(2026, 6, 3, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DueDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 5, 14, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(5955), new DateTime(2026, 6, 13, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(5954), new DateTime(2026, 5, 14, 21, 30, 10, 12, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 3, 21, 30, 10, 11, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 3, 21, 30, 10, 11, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 3, 21, 30, 10, 11, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2026, 6, 3, 21, 30, 10, 11, DateTimeKind.Utc).AddTicks(8726));
        }
    }
}
