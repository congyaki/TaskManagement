using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Migrations
{
    public partial class UpdateTblTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_TASK_FILES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TASK_ID = table.Column<int>(type: "int", nullable: false),
                    FILE_PATH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CREATED_BY = table.Column<int>(type: "int", nullable: true),
                    CREATED_AT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LAST_MODIFIED_BY = table.Column<int>(type: "int", nullable: true),
                    LAST_MODIFIED_AT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TASK_FILES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_TASK_FILES_TBL_TASKS_TASK_ID",
                        column: x => x.TASK_ID,
                        principalTable: "TBL_TASKS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TASK_FILES_TASK_ID",
                table: "TBL_TASK_FILES",
                column: "TASK_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_TASK_FILES");
        }
    }
}
