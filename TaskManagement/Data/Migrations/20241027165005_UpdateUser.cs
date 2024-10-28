using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagement.Data.Migrations
{
    public partial class UpdateUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "USER_ID",
                table: "TBL_TASK_USERS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TASK_USERS_USER_ID",
                table: "TBL_TASK_USERS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_TBL_DM_DEPARTMENTS_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId",
                principalTable: "TBL_DM_DEPARTMENTS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_TASK_USERS_AspNetUsers_USER_ID",
                table: "TBL_TASK_USERS",
                column: "USER_ID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_TBL_DM_DEPARTMENTS_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_TASK_USERS_AspNetUsers_USER_ID",
                table: "TBL_TASK_USERS");

            migrationBuilder.DropIndex(
                name: "IX_TBL_TASK_USERS_USER_ID",
                table: "TBL_TASK_USERS");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "USER_ID",
                table: "TBL_TASK_USERS",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
