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
    internal class StudCourseConfigurations : IEntityTypeConfiguration<StudCourse>
    {
        public void Configure(EntityTypeBuilder<StudCourse> builder)
        {
            builder.HasKey(CS => new { CS.StudId, CS.CourseId });

            builder.HasOne(SC => SC.Student)
                   .WithMany(S => S.StudCourse)
                   .HasForeignKey(SC => SC.StudId);

            builder.HasOne(SC => SC.Course)
                   .WithMany(C => C.StudCourse)
                   .HasForeignKey(SC => SC.CourseId);
        }
    }
}
