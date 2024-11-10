using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Migrations
{
    public partial class AddCodeColumnToTblTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_COMMENTS_TBL_TASKS_TASK_ID",
                table: "TBL_COMMENTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_COMMENTS_Users_USER_ID",
                table: "TBL_COMMENTS");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_TBL_DM_DEPARTMENTS_DepartmentId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "CODE",
                table: "TBL_TASKS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_COMMENTS_TBL_TASKS_TASK_ID",
                table: "TBL_COMMENTS",
                column: "TASK_ID",
                principalTable: "TBL_TASKS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_COMMENTS_Users_USER_ID",
                table: "TBL_COMMENTS",
                column: "USER_ID",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_TBL_DM_DEPARTMENTS_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "TBL_DM_DEPARTMENTS",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_COMMENTS_TBL_TASKS_TASK_ID",
                table: "TBL_COMMENTS");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_COMMENTS_Users_USER_ID",
                table: "TBL_COMMENTS");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_TBL_DM_DEPARTMENTS_DepartmentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CODE",
                table: "TBL_TASKS");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_COMMENTS_TBL_TASKS_TASK_ID",
                table: "TBL_COMMENTS",
                column: "TASK_ID",
                principalTable: "TBL_TASKS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_COMMENTS_Users_USER_ID",
                table: "TBL_COMMENTS",
                column: "USER_ID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_TBL_DM_DEPARTMENTS_DepartmentId",
                table: "Users",
                column: "DepartmentId",
                principalTable: "TBL_DM_DEPARTMENTS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
