//using Domain.Interfaces;
using Domain.Base;
using LanguageExt;
using LanguageExt.ClassInstances.Pred;
using LanguageExt.DataTypes.Serialisation;
using MediatR;
using NewOnlineCourseReg.Application.Commands;
using NewOnlineCourseReg.Application.DTOs;
using NewOnlineCourseReg.Application.Interfaces;
using NewOnlineCourseReg.Domain.CourseRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static LanguageExt.Prelude;

namespace NewOnlineCourseReg.Application.Handlers
{
    public class AddNewCourseCommandHandler : //BaseService,
                                              IRequestHandler<AddNewCourseCommand, Either<string, int>>
    {
        
       private readonly IUnitOfWork _unitOfWork;
        public AddNewCourseCommandHandler( IUnitOfWork unitOfWork) //: base(unitOfWork)
        {
           
            _unitOfWork = unitOfWork;
        }

       // public record StudentName(string Firstname, string Lastname);

        public async Task<Either<string, int>> Handle(AddNewCourseCommand request, CancellationToken cancellationToken)
        {
          
            var users = await AddNewCourseAsync(request.course);
            return (users);

        }
        public async Task<Either<string, int>> AddNewCourseAsync(AddCourseRequest model)
        {

           // var repository = _unitOfWork.AsyncRepository<Student>();
            var repository = _unitOfWork.studentRepository;

            var Eitherastudent =await  repository.GetWtExtension(filter: s => s.StudentId == model.StudentId, includeProperties: "CourseRegistrationForms.coursesForm");


            return  Eitherastudent.
                Map<Student>(GetActualStudent)
               .Bind (x => AddACourse(x, model,repository).Result);
          


        }

        private async Task<Either<string,int>> AddACourse(Student astudent, AddCourseRequest model  , IAsyncRepository<Student> repository)
        {
            var newCourse = model.ToCourse();
            var result = astudent.FindCourseRegistrationForm(newCourse);
            if (result != null)
            {
                var crs = astudent.FindCourseInRegistrationForm(result, newCourse);
                if (crs == null)
                {
                    result.coursesForm.Add(newCourse);
                }
            }
            
            await repository.UpdateAsync(astudent);
            try
            {

                var x = await _unitOfWork.SaveChangesAsync();
                return Right(x);
            }
            catch (Exception ex)
            {

                return Left(ex.ToString());
            }
        }




        private Student GetActualStudent(IEnumerable<Student> studentlist)
        {
            return studentlist.First();
        }


        //public async Task<AddCourseResponse> AddNewCourseAsync2(AddCourseRequest model)
        //{

        //    var repository = _unitOfWork.AsyncRepository<Student>();
        //    var astudent = repository.Get(filter: s => s.StudentId == model.StudentId, includeProperties: "CourseRegistrationForms.coursesForm").First();

        //    if (astudent != null)
        //    {
        //        var newCourse = model.ToCourse();
        //        var result = astudent.FindCourseRegistrationForm(newCourse);
        //        if (result != null)
        //        {
        //            var crs = astudent.FindCourseInRegistrationForm(result, newCourse);
        //            if (crs == null)
        //            {
        //                result.coursesForm.Add(newCourse);
        //            }
        //        }

        //        await repository.UpdateAsync(astudent);
                
        //        await _unitOfWork.SaveChangesAsync();

        //        return new AddCourseResponse(model.CampId, model.FacId);

        //    }

        //    throw new Exception("User not found.");
        //}

    }
}
