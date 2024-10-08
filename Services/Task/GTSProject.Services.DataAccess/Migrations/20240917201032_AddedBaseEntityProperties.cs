using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GTSProject.Services.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedBaseEntityProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Tribes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Tribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "Tribes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Tribes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Tribes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tribes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "Tribes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Tribes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TribeMembers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TribeMembers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TribeMembers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TribeMembers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TribeMembers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TribeMembers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TribeMembers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TribeMembers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TribeMemberRoles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TribeMemberRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TribeMemberRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TribeMemberRoles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TribeMemberRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TribeMemberRoles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TribeMemberRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TribeMemberRoles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskWatchers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskWatchers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskWatchers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskWatchers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskWatchers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskWatchers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskWatchers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskWatchers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskSubjectTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskSubjectTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskSubjectTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskSubjectTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskSubjectTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskSubjectTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskSubjectTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskSubjectTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskStatusLogs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskStatusLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskStatusLogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskStatusLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskStatusLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskStatusLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskStatusLogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskStatusLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskStatuses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskStatuses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskStatuses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskStatuses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskStatuses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Tasks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Tasks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskResponsibles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskResponsibles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskResponsibles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskResponsibles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskResponsibles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskResponsibles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskResponsibles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskResponsibles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskRelationTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskRelationTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskRelationTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskRelationTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskRelationTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskRelationTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskRelationTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskRelationTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskRelations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskRelations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskRelations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskRelations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskRelations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskRelations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskRelations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskReasons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskReasons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskReasons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskReasons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskReasons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskReasons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskReasons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskReasons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskRatings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskRatings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskRatings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskRatings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskRatings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskRatings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskRatings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskRatings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskProjects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskProjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskProjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskProjects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskProjects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskProjects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskProjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskProjects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskHistories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskHistories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskHistories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskEffortTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskEffortTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskEffortTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskEffortTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskEffortTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskEffortTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskEffortTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskEffortTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskEfforts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskEfforts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskEfforts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskEfforts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskEfforts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskEfforts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskEfforts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskEfforts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskDeadLineLogs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskDeadLineLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskDeadLineLogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskDeadLineLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskDeadLineLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskDeadLineLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskDeadLineLogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskDeadLineLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskComments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskComments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskComments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskComments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskComments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskComments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskComments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskColorRules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskColorRules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskColorRules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskColorRules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskColorRules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskColorRules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskColorRules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskColorRules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskCategories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskCategories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskAutoAssignRules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskAutoAssignRules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskAutoAssignRules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskAutoAssignRules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskAutoAssignRules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskAutoAssignRules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskAutoAssignRules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskAutoAssignRules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TaskAttachments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskAttachments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "TaskAttachments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "TaskAttachments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaskAttachments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TaskAttachments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "TaskAttachments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "TaskAttachments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "SprintStatuses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "SprintStatuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "SprintStatuses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "SprintStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "SprintStatuses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SprintStatuses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "SprintStatuses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "SprintStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Sprints",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Sprints",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "Sprints",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Sprints",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Sprints",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sprints",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "Sprints",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Sprints",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "QuickAnswers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "QuickAnswers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "QuickAnswers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "QuickAnswers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "QuickAnswers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "QuickAnswers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "QuickAnswers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "QuickAnswers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "KeywordToTaskReasons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "KeywordToTaskReasons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "KeywordToTaskReasons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "KeywordToTaskReasons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "KeywordToTaskReasons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "KeywordToTaskReasons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "KeywordToTaskReasons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "KeywordToTaskReasons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "DailyTaskStatusLogs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "DailyTaskStatusLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "DeleteBy",
                table: "DailyTaskStatusLogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "DailyTaskStatusLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "DailyTaskStatusLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DailyTaskStatusLogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdateBy",
                table: "DailyTaskStatusLogs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "DailyTaskStatusLogs",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tribes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Tribes");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Tribes");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Tribes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Tribes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tribes");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Tribes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Tribes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TribeMembers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TribeMembers");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TribeMembers");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TribeMembers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TribeMembers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TribeMembers");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TribeMembers");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TribeMembers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TribeMemberRoles");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TribeMemberRoles");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TribeMemberRoles");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TribeMemberRoles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TribeMemberRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TribeMemberRoles");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TribeMemberRoles");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TribeMemberRoles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskWatchers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskWatchers");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskWatchers");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskWatchers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskWatchers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskWatchers");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskWatchers");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskWatchers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskSubjectTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskSubjectTypes");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskSubjectTypes");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskSubjectTypes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskSubjectTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskSubjectTypes");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskSubjectTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskSubjectTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskStatuses");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskStatuses");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskStatuses");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskStatuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskStatuses");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskStatuses");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskResponsibles");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskResponsibles");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskResponsibles");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskResponsibles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskResponsibles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskResponsibles");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskResponsibles");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskResponsibles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskRelationTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskRelationTypes");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskRelationTypes");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskRelationTypes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskRelationTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskRelationTypes");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskRelationTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskRelationTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskRelations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskRelations");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskRelations");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskRelations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskRelations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskRelations");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskRelations");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskRelations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskReasons");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskReasons");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskReasons");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskReasons");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskReasons");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskReasons");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskReasons");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskReasons");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskRatings");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskRatings");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskRatings");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskRatings");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskRatings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskRatings");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskRatings");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskRatings");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskProjects");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskHistories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskHistories");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskHistories");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskHistories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskHistories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskHistories");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskHistories");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskHistories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskEffortTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskEffortTypes");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskEffortTypes");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskEffortTypes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskEffortTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskEffortTypes");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskEffortTypes");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskEffortTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskEfforts");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskEfforts");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskEfforts");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskEfforts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskEfforts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskEfforts");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskEfforts");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskEfforts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskDeadLineLogs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskDeadLineLogs");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskDeadLineLogs");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskDeadLineLogs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskDeadLineLogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskDeadLineLogs");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskDeadLineLogs");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskDeadLineLogs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskComments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskComments");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskComments");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskComments");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskComments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskComments");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskComments");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskComments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskColorRules");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskColorRules");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskColorRules");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskColorRules");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskColorRules");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskColorRules");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskColorRules");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskColorRules");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskCategories");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskCategories");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskCategories");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskCategories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskCategories");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskCategories");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskAutoAssignRules");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskAutoAssignRules");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskAutoAssignRules");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskAutoAssignRules");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskAutoAssignRules");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskAutoAssignRules");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskAutoAssignRules");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskAutoAssignRules");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TaskAttachments");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskAttachments");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "TaskAttachments");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "TaskAttachments");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaskAttachments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TaskAttachments");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "TaskAttachments");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "TaskAttachments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SprintStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "SprintStatuses");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "SprintStatuses");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "SprintStatuses");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "SprintStatuses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SprintStatuses");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "SprintStatuses");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "SprintStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "QuickAnswers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "QuickAnswers");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "QuickAnswers");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "QuickAnswers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "QuickAnswers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "QuickAnswers");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "QuickAnswers");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "QuickAnswers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "KeywordToTaskReasons");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "KeywordToTaskReasons");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "KeywordToTaskReasons");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "KeywordToTaskReasons");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "KeywordToTaskReasons");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "KeywordToTaskReasons");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "KeywordToTaskReasons");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "KeywordToTaskReasons");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DailyTaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DailyTaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "DailyTaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "DailyTaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "DailyTaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DailyTaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "DailyTaskStatusLogs");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "DailyTaskStatusLogs");
        }
    }
}
