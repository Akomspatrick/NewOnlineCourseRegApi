using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewOnlineCourseReg.Domain.CourseRegistration;

namespace Infrastructure.Data.EntitiesConfig
{
    class CourseRegistrationFormConfig :      IEntityTypeConfiguration<CourseRegistrationForm>
    {
        public void Configure(EntityTypeBuilder<CourseRegistrationForm> builder)
    {
        builder.HasKey(p => new { p.StudentId,p.session, p.semester });
            //builder.HasKey(p => new {  p.StudentId });

            builder.Property(p => p.semester)//.HasMaxLength(2)
            .IsRequired();

       // builder.HasOne(p => p.student) ;
        builder.HasOne(p => p.student).WithMany(p=>p.CourseRegistrationForms).HasForeignKey(p=>p.StudentId);
            // builder.HasOne(p => p.coursesForm).WithMany(p => p.);



            // Note: Uses anonomous types to seed foreign keys
            builder.HasData(
               new //CourseRegistrationForm()
               {
                   StudentId = "1",
                   semester = "1",
                   session = "1",
                   maxPossibleTotalUnit = 2,
                   minPossibleTotalUnit = 2,
               },
                    new //CourseRegistrationForm()
                    {
                        StudentId = "1",
                        semester = "2",
                        session = "1",
                        maxPossibleTotalUnit = 2,
                        minPossibleTotalUnit = 2,
                    }
               );
                   //    {
                   //        Id = 1,
                   //        Date = DateTime.Parse("2022-01-01"),
                   //        CustomerId = 1,
                   //        EmployeeId = 1,
                   //        ProductId = 1,
                   //        UnitPrice = 5m,
                   //        Quantity = 1,
                   //        TotalPrice = 5m
                   //    },
                   //    new
                   //    {
                   //        Id = 2,
                   //        Date = DateTime.Parse("2022-01-02"),
                   //        CustomerId = 2,
                   //        EmployeeId = 2,
                   //        ProductId = 2,
                   //        UnitPrice = 10m,
                   //        Quantity = 2,
                   //        TotalPrice = 20m
                   //    },
                   //    new
                   //    {
                   //        Id = 3,
                   //        Date = DateTime.Parse("2022-01-03"),
                   //        CustomerId = 3,
                   //        EmployeeId = 3,
                   //        ProductId = 3,
                   //        UnitPrice = 15m,
                   //        Quantity = 3,
                   //        TotalPrice = 45m
                   //    });
               }


    }
}
