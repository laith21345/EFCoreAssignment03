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
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(S => S.FName)
                   .HasMaxLength(15);

            builder.Property(S => S.LName)
                   .HasMaxLength(20);

            builder.HasOne(S => S.Department)
                   .WithMany(D => D.Students)
                   .HasForeignKey(S => S.DeptId);

        }
    }
}
