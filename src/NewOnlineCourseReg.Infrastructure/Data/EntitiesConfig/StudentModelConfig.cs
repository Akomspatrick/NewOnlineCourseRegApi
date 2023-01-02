using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NewOnlineCourseReg.Infrastructure.Data.Repositories.Models;

namespace NewOnlineCourseReg.Infrastructure.Data.EntitiesConfig
{
    public class StudentModelConfig : IEntityTypeConfiguration<Student>
    {

        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasKey(p => p.StudentId);
            // builder.HasMany(p => p.CourseRegistrationForm).
            builder.Property(p => p.StudentId).HasMaxLength(10);
            builder.OwnsOne(p => p.Name, nameBuilder =>
            {
                nameBuilder.Property(p => p.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(20);
                nameBuilder.Property(p => p.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(20); ;
            });


            builder.HasData(
                   new { StudentId = "1" },
                   new { StudentId = "11" });

            builder.OwnsOne(p => p.Name).HasData(
                new { FirstName = "SpaghettO1", LastName = "Spaghetti1", StudentId = "1" },
                 new { FirstName = "Spaghett11", LastName = "Spaghetti11", StudentId = "11" }
                );
        }
    }

  
}