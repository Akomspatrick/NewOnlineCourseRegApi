using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.EntitiesConfig
{
    class CourseRegistrationFormModelConfig :      IEntityTypeConfiguration<NewOnlineCourseReg.Infrastructure.Data.Repositories.Models.CourseRegistrationForm>
    {
        public void Configure(EntityTypeBuilder<NewOnlineCourseReg.Infrastructure.Data.Repositories.Models.CourseRegistrationForm> builder)
    {
            builder.HasKey(p => new { p.StudentId,p.session, p.semester });
            builder.Property(p => p.semester)//.HasMaxLength(2)
            .IsRequired();
            builder.HasOne(p => p.student).WithMany(p=>p.CourseRegistrationForms).HasForeignKey(p=>p.StudentId);

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

               }


    }
}
