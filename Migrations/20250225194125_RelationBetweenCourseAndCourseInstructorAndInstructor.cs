using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Program.Migrations
{
    /// <inheritdoc />
    public partial class RelationBetweenCourseAndCourseInstructorAndInstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructor_InstId",
                table: "CourseInstructor",
                column: "InstId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructor_Courses_CourseId",
                table: "CourseInstructor",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructor_Instructors_InstId",
                table: "CourseInstructor",
                column: "InstId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructor_Courses_CourseId",
                table: "CourseInstructor");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructor_Instructors_InstId",
                table: "CourseInstructor");

            migrationBuilder.DropIndex(
                name: "IX_CourseInstructor_InstId",
                table: "CourseInstructor");
        }
    }
}
