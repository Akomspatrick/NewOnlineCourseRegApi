using LanguageExt;
using MediatR;
using NewOnlineCourseReg.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOnlineCourseReg.Application.Commands
{
    public record AddNewCourseCommand( AddCourseRequest course) : IRequest<Either<string, int>>;

}
