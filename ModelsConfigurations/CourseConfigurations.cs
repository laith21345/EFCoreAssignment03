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
    internal class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(C => C.Name)
                   .HasMaxLength(20);

            builder.HasOne(C => C.Topic)
                   .WithMany(T => T.Courses)
                   .HasForeignKey(C => C.TopId);
        }
    }
}
