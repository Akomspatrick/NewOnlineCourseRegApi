using Domain.Base;
using NewOnlineCourseReg.Domain.ValueObjects;
using System.Collections.ObjectModel;

namespace NewOnlineCourseReg.Infrastructure.Data.Repositories.Models
{
    public partial class Student : BaseEntity<string>
    {


        private Student() { }
        public Student(string Id, StudentName name, List<CourseRegistrationForm> courseRegistrationForms)
        {
            // check to make sure valid input are passed
            StudentId = Id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            CourseRegistrationForms = new ReadOnlyCollection<CourseRegistrationForm>(courseRegistrationForms);
            // _courseRegistrationForms = new List<CourseRegistrationForm>(courseRegistrationForms);

        }

        // public string StudentId { get; set; }   
        public StudentName Name { get; init; }
        //try a backing field

        // public List<CourseRegistrationForm> _courseRegistrationForms=  Enumerable.Empty<CourseRegistrationForm>().ToList(); 
        public IReadOnlyCollection<CourseRegistrationForm> CourseRegistrationForms
        {
            get;
            init;
        }
    }
}
