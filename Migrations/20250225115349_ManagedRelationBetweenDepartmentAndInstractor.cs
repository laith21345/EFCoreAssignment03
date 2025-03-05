using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Program.Migrations
{
    /// <inheritdoc />
    public partial class ManagedRelationBetweenDepartmentAndInstractor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Departments_InsId",
                table: "Departments",
                column: "InsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InsId",
                table: "Departments",
                column: "InsId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InsId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InsId",
                table: "Departments");
        }
    }
}
