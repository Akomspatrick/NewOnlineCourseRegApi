using Microsoft.EntityFrameworkCore;
using NewOnlineCourseReg.Infrastructure.Data.Repositories.Models;

namespace Infrastructure.Data
{
    public class EFContext : DbContext
    {
  

        public DbSet<CourseRegistrationForm> CourseRegistrationForms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public EFContext(DbContextOptions<EFContext> options//, IConfiguration configuration
            ) : base(options)
        {
            //   _configuration = configuration;

          //  Database.EnsureCreated();
        }


        public void Save()
        {
            this.SaveChanges(); 
        }
    
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        ////    var connectionString = _configuration.GetConnectionString("DDDConnectionString");
        ////    optionsBuilder.UseSqlServer(connectionString);
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(EFContext).Assembly);
            //new CourseRegistrationFormConfig().Configure(builder.Entity<CourseRegistrationForm>());
            //new CourseConfig().Configure(builder.Entity<Course>());
            //new StudentConfig().Configure(builder.Entity<Student>());

        }
    }


}