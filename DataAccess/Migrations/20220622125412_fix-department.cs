using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class fixdepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lecturers_Departmants_DepartmantId",
                table: "Lecturers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departmants_DepartmantId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Departmants");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmantId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DepartmantId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DepartmantId",
                table: "Lecturers",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Lecturers_DepartmantId",
                table: "Lecturers",
                newName: "IX_Lecturers_DepartmentId");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lecturers_Departments_DepartmentId",
                table: "Lecturers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lecturers_Departments_DepartmentId",
                table: "Lecturers");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Lecturers",
                newName: "DepartmantId");

            migrationBuilder.RenameIndex(
                name: "IX_Lecturers_DepartmentId",
                table: "Lecturers",
                newName: "IX_Lecturers_DepartmantId");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmantId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Departmants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmants", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmantId",
                table: "Students",
                column: "DepartmantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lecturers_Departmants_DepartmantId",
                table: "Lecturers",
                column: "DepartmantId",
                principalTable: "Departmants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departmants_DepartmantId",
                table: "Students",
                column: "DepartmantId",
                principalTable: "Departmants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
