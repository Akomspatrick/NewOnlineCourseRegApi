using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOnlineCourseReg.Application.Commands
{
    internal class AddNewCourseCommandValidator :AbstractValidator<AddNewCourseCommand>
    {
        public AddNewCourseCommandValidator() { 
        RuleFor(v=>v.course.CourseId).MinimumLength(3).MaximumLength(6).NotEmpty();
                
                }
    }

    public interface gettingstring
    {
        void Mapping(string s);
        void Mapper(string s)=> s.ToArr();
    }
}
