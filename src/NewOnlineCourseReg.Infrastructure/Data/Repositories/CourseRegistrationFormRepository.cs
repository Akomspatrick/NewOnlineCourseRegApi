using Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;
using NewOnlineCourseReg.Domain.CourseRegistration;
using NewOnlineCourseReg.Application.Interfaces;

namespace NewOnlineCourseReg.Infrastructure.Data.Repositories
{
    public class CourseRegistrationFormRepository : RepositoryBase<CourseRegistrationForm>
        , ICourseRegistrationFormRepository
    {
        public CourseRegistrationFormRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}
