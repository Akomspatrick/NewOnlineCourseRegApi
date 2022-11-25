using Infrastructure.Data.Repositories;
using Infrastructure.Data;
using NewOnlineCourseReg.Application.Interfaces;
using NewOnlineCourseReg.Domain.CourseRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOnlineCourseReg.Infrastructure.Data.Repositories
{
    public class StudentRepository : RepositoryBase<Student>
        , IStudentRepository
    {
        public StudentRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}