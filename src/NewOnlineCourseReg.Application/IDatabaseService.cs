using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewOnlineCourseReg.Domain.CourseRegistration;

namespace NewOnlineCourseReg.Application
{
    public interface IDatabaseService
    {
        DbSet<CourseRegistrationForm> CourseRegistrationForms { get; set; }

        DbSet<Course> Courses { get; set; }

        DbSet<Student> Students { get; set; }



        void Save();
    }
}
