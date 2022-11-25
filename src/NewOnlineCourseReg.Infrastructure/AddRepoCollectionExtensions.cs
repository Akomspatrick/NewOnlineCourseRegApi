
//using Domain.Interfaces;

using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewOnlineCourseReg.Application.Interfaces;

namespace NewOnlineCourseRegApi.Infrastructure
{
    public static class AddRepoCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
              //  .AddScoped<ICourseRegistrationFormRepository, CourseRegistrationFormRepository>();
            // .AddScoped<IDepartmentRepository, DepartmentRepository>();
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services
            , IConfiguration configuration)
        {
            return services.AddDbContext<EFContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DDDConnectionString"));
               // options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
        }


    }
}