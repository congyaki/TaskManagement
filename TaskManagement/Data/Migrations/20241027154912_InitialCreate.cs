using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_DM_DEPARTMENTS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LAST_MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_MODIFIED_AT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DM_DEPARTMENTS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_DM_LABELS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COLOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LAST_MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_MODIFIED_AT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_DM_LABELS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_FAILED_JOBS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CONNECTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QUEUE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAYLOAD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EXCEPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FAILED_AT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_FAILED_JOBS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_JOBS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QUEUE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAYLOAD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ATTEMPTS = table.Column<int>(type: "int", nullable: false),
                    RESERVED_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AVAILABLE_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_JOBS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TASKS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    START_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    END_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRIORITY = table.Column<int>(type: "int", nullable: true),
                    ESTIMATED_TIME = table.Column<double>(type: "float", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LAST_MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_MODIFIED_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DEPARTMENT_ID = table.Column<int>(type: "int", nullable: false),
                    PARENT_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TASKS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_TASKS_TBL_DM_DEPARTMENTS_DEPARTMENT_ID",
                        column: x => x.DEPARTMENT_ID,
                        principalTable: "TBL_DM_DEPARTMENTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_TASKS_TBL_TASKS_PARENT_ID",
                        column: x => x.PARENT_ID,
                        principalTable: "TBL_TASKS",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TBL_COMMENTS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TASK_ID = table.Column<int>(type: "int", nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    CONTENT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_MODIFIED_AT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_COMMENTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_COMMENTS_TBL_TASKS_TASK_ID",
                        column: x => x.TASK_ID,
                        principalTable: "TBL_TASKS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TASK_LABELS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TASK_ID = table.Column<int>(type: "int", nullable: false),
                    LABEL_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LAST_MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_MODIFIED_AT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TASK_LABELS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_TASK_LABELS_TBL_DM_LABELS_LABEL_ID",
                        column: x => x.LABEL_ID,
                        principalTable: "TBL_DM_LABELS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_TASK_LABELS_TBL_TASKS_TASK_ID",
                        column: x => x.TASK_ID,
                        principalTable: "TBL_TASKS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TASK_USERS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TASK_ID = table.Column<int>(type: "int", nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    CREATED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LAST_MODIFIED_BY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_MODIFIED_AT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TASK_USERS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_TASK_USERS_TBL_TASKS_TASK_ID",
                        column: x => x.TASK_ID,
                        principalTable: "TBL_TASKS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_COMMENTS_TASK_ID",
                table: "TBL_COMMENTS",
                column: "TASK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TASK_LABELS_LABEL_ID",
                table: "TBL_TASK_LABELS",
                column: "LABEL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TASK_LABELS_TASK_ID",
                table: "TBL_TASK_LABELS",
                column: "TASK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TASK_USERS_TASK_ID",
                table: "TBL_TASK_USERS",
                column: "TASK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TASKS_DEPARTMENT_ID",
                table: "TBL_TASKS",
                column: "DEPARTMENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TASKS_PARENT_ID",
                table: "TBL_TASKS",
                column: "PARENT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_COMMENTS");

            migrationBuilder.DropTable(
                name: "TBL_FAILED_JOBS");

            migrationBuilder.DropTable(
                name: "TBL_JOBS");

            migrationBuilder.DropTable(
                name: "TBL_TASK_LABELS");

            migrationBuilder.DropTable(
                name: "TBL_TASK_USERS");

            migrationBuilder.DropTable(
                name: "TBL_DM_LABELS");

            migrationBuilder.DropTable(
                name: "TBL_TASKS");

            migrationBuilder.DropTable(
                name: "TBL_DM_DEPARTMENTS");
        }
    }
}
