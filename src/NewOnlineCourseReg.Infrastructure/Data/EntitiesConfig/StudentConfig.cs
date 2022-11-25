using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewOnlineCourseReg.Domain.CourseRegistration;
using NewOnlineCourseReg.Domain.ValueObjects;

namespace NewOnlineCourseReg.Infrastructure.Data.EntitiesConfig
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
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

            //builder.Property(p => p.Name)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //builder.Property(p => p.Price)
            //    .IsRequired()
            //    .HasPrecision(5, 2);
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