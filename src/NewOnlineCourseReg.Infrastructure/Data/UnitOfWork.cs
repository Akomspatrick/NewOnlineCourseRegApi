using Domain.Base;
//using Domain.Interfaces;
using Infrastructure.Data.Repositories;
using LanguageExt;
using Microsoft.EntityFrameworkCore;
using NewOnlineCourseReg.Application.Interfaces;
using NewOnlineCourseReg.Domain.CourseRegistration;
using NewOnlineCourseReg.Infrastructure.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFContext _dbContext;

        public UnitOfWork(EFContext dbContext)
        {
            _dbContext = dbContext;
            studentRepository = new StudentRepository(dbContext);

        }
        public IStudentRepository studentRepository { get; private set; }



        public IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity
        {
            return new RepositoryBase<T>(_dbContext);
        }

        public Task<int> SaveChangesAsync()
        {
            try
            {
                return _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

 
    }
}