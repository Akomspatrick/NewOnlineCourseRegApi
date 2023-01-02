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
        EFContext Context;
        public StudentRepository(EFContext dbContext) : base(dbContext)
        {
            Context = dbContext;
        }

        public EFContext EFContext
        {
            get { return Context as EFContext; }
        }

        //public override void Add(Student entity)
        //{
        //    // We can override repository virtual methods in order to customize repository behavior, Template Method Pattern
        //    // Code here

        //    base.Add(entity);
        //}
    }
}