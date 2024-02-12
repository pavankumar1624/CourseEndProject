using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace courseEndProject.Migrations
{
    public partial class EmpMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeptMaster0",
                columns: table => new
                {
                    DeptCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptMaster0", x => x.DeptCode);
                });

            migrationBuilder.CreateTable(
                name: "EmpProfile",
                columns: table => new
                {
                    EmpCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptCode = table.Column<int>(type: "int", nullable: false),
                    DeptMasterDeptCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpProfile", x => x.EmpCode);
                    table.ForeignKey(
                        name: "FK_EmpProfile_DeptMaster0_DeptMasterDeptCode",
                        column: x => x.DeptMasterDeptCode,
                        principalTable: "DeptMaster0",
                        principalColumn: "DeptCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpProfile_DeptMasterDeptCode",
                table: "EmpProfile",
                column: "DeptMasterDeptCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpProfile");

            migrationBuilder.DropTable(
                name: "DeptMaster0");
        }
    }
}
