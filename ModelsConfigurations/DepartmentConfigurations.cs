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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Name)
                   .HasMaxLength(20);

            builder.Property(D => D.HiringDate)
                   .HasDefaultValueSql("GETDATE()");

            builder.HasOne(D => D.Manager)
                   .WithOne(I => I.ManagedDepartment)
                   .HasForeignKey<Department>(D => D.InsId);
                   //.OnDelete(DeleteBehavior.);
        }
    }
}
