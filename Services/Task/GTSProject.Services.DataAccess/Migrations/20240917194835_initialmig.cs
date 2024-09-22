using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GTSProject.Services.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SprintStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SprintStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskAutoAssignRules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssigneeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAutoAssignRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<int>(type: "int", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ParentTaskCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskCategories_TaskCategories_ParentTaskCategoryId",
                        column: x => x.ParentTaskCategoryId,
                        principalTable: "TaskCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TaskColorRules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskColorRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShowToAllUser = table.Column<bool>(type: "bit", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskReasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskRelationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskRelationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskSubjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskSubjectTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TribeMemberRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TribeMemberRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskEffortTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskEffortTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskEffortTypes_TaskCategories_TaskCategoryId",
                        column: x => x.TaskCategoryId,
                        principalTable: "TaskCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tribes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tribes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tribes_TaskProjects_TaskProjectId",
                        column: x => x.TaskProjectId,
                        principalTable: "TaskProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KeywordToTaskReasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskCategoryId = table.Column<int>(type: "int", nullable: false),
                    TaskReasonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordToTaskReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeywordToTaskReasons_TaskCategories_TaskCategoryId",
                        column: x => x.TaskCategoryId,
                        principalTable: "TaskCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KeywordToTaskReasons_TaskReasons_TaskReasonId",
                        column: x => x.TaskReasonId,
                        principalTable: "TaskReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuickAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskReasonId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuickAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuickAnswers_TaskReasons_TaskReasonId",
                        column: x => x.TaskReasonId,
                        principalTable: "TaskReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkLoad = table.Column<int>(type: "int", nullable: false),
                    HasAttachment = table.Column<int>(type: "int", nullable: false),
                    ReporterIsRight = table.Column<int>(type: "int", nullable: false),
                    ReplyEmail = table.Column<int>(type: "int", nullable: false),
                    ReplyPhone = table.Column<int>(type: "int", nullable: false),
                    EffortDevelopment = table.Column<int>(type: "int", nullable: false),
                    EffortAnalyse = table.Column<int>(type: "int", nullable: false),
                    EffortTechnic = table.Column<int>(type: "int", nullable: false),
                    PendingOn = table.Column<int>(type: "int", nullable: false),
                    PriorityOrder = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ParentTaskId = table.Column<int>(type: "int", nullable: true),
                    TaskProjectId = table.Column<int>(type: "int", nullable: false),
                    TaskTypeId = table.Column<int>(type: "int", nullable: false),
                    ReporterId = table.Column<int>(type: "int", nullable: false),
                    AssigneeId = table.Column<int>(type: "int", nullable: false),
                    TaskCategoryId = table.Column<int>(type: "int", nullable: false),
                    TaskStatusId = table.Column<int>(type: "int", nullable: false),
                    TaskReasonId = table.Column<int>(type: "int", nullable: false),
                    TaskSubjectTypeId = table.Column<int>(type: "int", nullable: false),
                    CloserId = table.Column<int>(type: "int", nullable: false),
                    CloserDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskCategories_TaskCategoryId",
                        column: x => x.TaskCategoryId,
                        principalTable: "TaskCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskProjects_TaskProjectId",
                        column: x => x.TaskProjectId,
                        principalTable: "TaskProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskReasons_TaskReasonId",
                        column: x => x.TaskReasonId,
                        principalTable: "TaskReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskStatuses_TaskStatusId",
                        column: x => x.TaskStatusId,
                        principalTable: "TaskStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskSubjectTypes_TaskSubjectTypeId",
                        column: x => x.TaskSubjectTypeId,
                        principalTable: "TaskSubjectTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskTypes_TaskTypeId",
                        column: x => x.TaskTypeId,
                        principalTable: "TaskTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Tasks_ParentTaskId",
                        column: x => x.ParentTaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sprints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateWeekNumber = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskProjectId = table.Column<int>(type: "int", nullable: false),
                    TribeId = table.Column<int>(type: "int", nullable: false),
                    SprintStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sprints_SprintStatuses_SprintStatusId",
                        column: x => x.SprintStatusId,
                        principalTable: "SprintStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sprints_TaskProjects_TaskProjectId",
                        column: x => x.TaskProjectId,
                        principalTable: "TaskProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sprints_Tribes_TribeId",
                        column: x => x.TribeId,
                        principalTable: "Tribes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TribeMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TribeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TribeMemberRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TribeMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TribeMembers_TribeMemberRoles_TribeMemberRoleId",
                        column: x => x.TribeMemberRoleId,
                        principalTable: "TribeMemberRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TribeMembers_Tribes_TribeId",
                        column: x => x.TribeId,
                        principalTable: "Tribes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasAttachment = table.Column<bool>(type: "bit", nullable: false),
                    ShowToAllUser = table.Column<bool>(type: "bit", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    QuickAnswerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskComments_QuickAnswers_QuickAnswerId",
                        column: x => x.QuickAnswerId,
                        principalTable: "QuickAnswers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskComments_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskDeadLineLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDeadLineLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDeadLineLogs_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskEfforts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Effort = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmedEffort = table.Column<int>(type: "int", nullable: false),
                    ConfirmedMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ConfirmedByUserId = table.Column<int>(type: "int", nullable: false),
                    TaskEffortTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskEfforts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskEfforts_TaskEffortTypes_TaskEffortTypeId",
                        column: x => x.TaskEffortTypeId,
                        principalTable: "TaskEffortTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskEfforts_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TaskStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskHistories_TaskStatuses_TaskStatusId",
                        column: x => x.TaskStatusId,
                        principalTable: "TaskStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskHistories_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AssigneeId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    TaskCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskRatings_TaskCategories_TaskCategoryId",
                        column: x => x.TaskCategoryId,
                        principalTable: "TaskCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskRatings_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId1 = table.Column<int>(type: "int", nullable: false),
                    TaskId2 = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TaskRelationTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskRelations_TaskRelationTypes_TaskRelationTypeId",
                        column: x => x.TaskRelationTypeId,
                        principalTable: "TaskRelationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskRelations_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskResponsibles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatorUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskResponsibles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskResponsibles_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskStatusLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    TaskStatusId = table.Column<int>(type: "int", nullable: false),
                    AssigneeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskStatusLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskStatusLogs_TaskStatuses_TaskStatusId",
                        column: x => x.TaskStatusId,
                        principalTable: "TaskStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskStatusLogs_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskWatchers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WatcherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskWatchers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskWatchers_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailyTaskStatusLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    AssigneeId = table.Column<int>(type: "int", nullable: false),
                    SprintId = table.Column<int>(type: "int", nullable: false),
                    TaskStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyTaskStatusLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyTaskStatusLogs_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyTaskStatusLogs_TaskStatuses_TaskStatusId",
                        column: x => x.TaskStatusId,
                        principalTable: "TaskStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DailyTaskStatusLogs_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FolderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowToAllUser = table.Column<bool>(type: "bit", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    TaskCommentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskAttachments_TaskComments_TaskCommentId",
                        column: x => x.TaskCommentId,
                        principalTable: "TaskComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskAttachments_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DailyTaskStatusLogs_SprintId",
                table: "DailyTaskStatusLogs",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyTaskStatusLogs_TaskId",
                table: "DailyTaskStatusLogs",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyTaskStatusLogs_TaskStatusId",
                table: "DailyTaskStatusLogs",
                column: "TaskStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_KeywordToTaskReasons_TaskCategoryId",
                table: "KeywordToTaskReasons",
                column: "TaskCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_KeywordToTaskReasons_TaskReasonId",
                table: "KeywordToTaskReasons",
                column: "TaskReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_QuickAnswers_TaskReasonId",
                table: "QuickAnswers",
                column: "TaskReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_SprintStatusId",
                table: "Sprints",
                column: "SprintStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_TaskProjectId",
                table: "Sprints",
                column: "TaskProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_TribeId",
                table: "Sprints",
                column: "TribeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAttachments_TaskCommentId",
                table: "TaskAttachments",
                column: "TaskCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAttachments_TaskId",
                table: "TaskAttachments",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskCategories_ParentTaskCategoryId",
                table: "TaskCategories",
                column: "ParentTaskCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskComments_QuickAnswerId",
                table: "TaskComments",
                column: "QuickAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskComments_TaskId",
                table: "TaskComments",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDeadLineLogs_TaskId",
                table: "TaskDeadLineLogs",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskEfforts_TaskEffortTypeId",
                table: "TaskEfforts",
                column: "TaskEffortTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskEfforts_TaskId",
                table: "TaskEfforts",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskEffortTypes_TaskCategoryId",
                table: "TaskEffortTypes",
                column: "TaskCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskHistories_TaskId",
                table: "TaskHistories",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskHistories_TaskStatusId",
                table: "TaskHistories",
                column: "TaskStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskRatings_TaskCategoryId",
                table: "TaskRatings",
                column: "TaskCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskRatings_TaskId",
                table: "TaskRatings",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskRelations_TaskId",
                table: "TaskRelations",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskRelations_TaskRelationTypeId",
                table: "TaskRelations",
                column: "TaskRelationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskResponsibles_TaskId",
                table: "TaskResponsibles",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ParentTaskId",
                table: "Tasks",
                column: "ParentTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskCategoryId",
                table: "Tasks",
                column: "TaskCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskProjectId",
                table: "Tasks",
                column: "TaskProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskReasonId",
                table: "Tasks",
                column: "TaskReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskStatusId",
                table: "Tasks",
                column: "TaskStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskSubjectTypeId",
                table: "Tasks",
                column: "TaskSubjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TaskTypeId",
                table: "Tasks",
                column: "TaskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskStatusLogs_TaskId",
                table: "TaskStatusLogs",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskStatusLogs_TaskStatusId",
                table: "TaskStatusLogs",
                column: "TaskStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskWatchers_TaskId",
                table: "TaskWatchers",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TribeMembers_TribeId",
                table: "TribeMembers",
                column: "TribeId");

            migrationBuilder.CreateIndex(
                name: "IX_TribeMembers_TribeMemberRoleId",
                table: "TribeMembers",
                column: "TribeMemberRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tribes_TaskProjectId",
                table: "Tribes",
                column: "TaskProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyTaskStatusLogs");

            migrationBuilder.DropTable(
                name: "KeywordToTaskReasons");

            migrationBuilder.DropTable(
                name: "TaskAttachments");

            migrationBuilder.DropTable(
                name: "TaskAutoAssignRules");

            migrationBuilder.DropTable(
                name: "TaskColorRules");

            migrationBuilder.DropTable(
                name: "TaskDeadLineLogs");

            migrationBuilder.DropTable(
                name: "TaskEfforts");

            migrationBuilder.DropTable(
                name: "TaskHistories");

            migrationBuilder.DropTable(
                name: "TaskRatings");

            migrationBuilder.DropTable(
                name: "TaskRelations");

            migrationBuilder.DropTable(
                name: "TaskResponsibles");

            migrationBuilder.DropTable(
                name: "TaskStatusLogs");

            migrationBuilder.DropTable(
                name: "TaskWatchers");

            migrationBuilder.DropTable(
                name: "TribeMembers");

            migrationBuilder.DropTable(
                name: "Sprints");

            migrationBuilder.DropTable(
                name: "TaskComments");

            migrationBuilder.DropTable(
                name: "TaskEffortTypes");

            migrationBuilder.DropTable(
                name: "TaskRelationTypes");

            migrationBuilder.DropTable(
                name: "TribeMemberRoles");

            migrationBuilder.DropTable(
                name: "SprintStatuses");

            migrationBuilder.DropTable(
                name: "Tribes");

            migrationBuilder.DropTable(
                name: "QuickAnswers");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "TaskCategories");

            migrationBuilder.DropTable(
                name: "TaskProjects");

            migrationBuilder.DropTable(
                name: "TaskReasons");

            migrationBuilder.DropTable(
                name: "TaskStatuses");

            migrationBuilder.DropTable(
                name: "TaskSubjectTypes");

            migrationBuilder.DropTable(
                name: "TaskTypes");
        }
    }
}
