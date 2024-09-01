using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GTSProject.Services.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TestWithDailyTaskStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyTaskStatusLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    AssigneeId = table.Column<int>(type: "int", nullable: false),
                    TaskCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SprintId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyTaskStatusLogs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyTaskStatusLogs");
        }
    }
}
