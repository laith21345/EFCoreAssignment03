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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Name)
                   .HasMaxLength(20);

            builder.HasOne(I => I.Department)
                   .WithMany(D => D.Instructors)
                   .HasForeignKey(I => I.DeptID)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
