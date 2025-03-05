using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Program.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenStudentAndStudCourseAndCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_CourseId",
                table: "StudCourse",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Courses_CourseId",
                table: "StudCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Students_StudId",
                table: "StudCourse",
                column: "StudId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Courses_CourseId",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Students_StudId",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_CourseId",
                table: "StudCourse");
        }
    }
}
