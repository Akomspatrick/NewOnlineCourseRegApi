using NewOnlineCourseReg.Domain.CourseRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOnlineCourseReg.Application.Interfaces
{
    public interface IStudentRepository : IAsyncRepository<Student>
    {

    }

}
