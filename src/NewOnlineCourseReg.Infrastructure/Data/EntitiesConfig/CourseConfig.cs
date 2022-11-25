using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NewOnlineCourseReg.Domain.CourseRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOnlineCourseReg.Infrastructure.Data.EntitiesConfig
{
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(p => new { p.StudentId, p.semester, p.session, p.CourseId });
            // builder.HasOne(b=> b.CourseRegistrationForm).WithMany(a=>a.coursesForm).HasForeignKey(p=>new { p.StudentId });
            // builder.HasOne(p => p.student).WithMany(p => p.CourseRegistrationForm).HasForeignKey(p => p.StudentId);
             builder.HasOne(p => p.CourseRegistrationForm).WithMany(p => p.coursesForm).HasForeignKey(p =>new  { p.StudentId,  p.session,p.semester });
          //  builder.HasOne(p => p.CourseRegistrationForm).WithMany(p => p.coursesForm).HasForeignKey("StudentId");

            builder.Property(p => p.FacId)
                .IsRequired()
                .HasMaxLength(50);

            //builder.Property(p => p.)
            //    .IsRequired()
            //    .HasPrecision(5, 2);

            builder.HasData(
                new Course() { CampId = "d", FacId = "s",StudentId = "1", session = "1" ,semester = "1", CourseId = "111" },
                new Course() { CampId = "d", FacId = "s", StudentId = "1", session = "1", semester = "1", CourseId = "113" },
                new Course() { CampId = "d", FacId = "s", StudentId = "1", session = "1", semester = "1", CourseId = "114" }


                );
        }
    }
}