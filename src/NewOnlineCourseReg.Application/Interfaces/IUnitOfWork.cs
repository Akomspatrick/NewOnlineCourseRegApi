using Domain.Base;
using NewOnlineCourseReg.Domain.CourseRegistration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewOnlineCourseReg.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();

        IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity;
    }
}

