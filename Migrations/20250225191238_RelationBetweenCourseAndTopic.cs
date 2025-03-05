using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Program.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenCourseAndTopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopId",
                table: "Courses",
                column: "TopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopId",
                table: "Courses",
                column: "TopId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopId",
                table: "Courses");
        }
    }
}
