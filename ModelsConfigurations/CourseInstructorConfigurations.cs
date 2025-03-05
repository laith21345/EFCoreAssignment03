using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Program.Modules;

namespace Program.ModelsConfigurations
{
    internal class CourseInstructorConfigurations : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.HasKey(CI => new {CI.CourseId,CI.InstId});

            builder.Property(CI => CI.Evaluation)
                   .HasMaxLength(20);

            builder.HasOne(CI => CI.Course)
                   .WithMany(C => C.CourseInstructor)
                   .HasForeignKey(CI => CI.CourseId);

            builder.HasOne(CI => CI.Instructor)
                   .WithMany(I => I.CourseInstructor)
                   .HasForeignKey(CI => CI.InstId);
        }
    }
}
