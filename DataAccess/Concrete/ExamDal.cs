using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.ExamDtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccess.Concrete
{
    public class ExamDal : GenericRepository<Exam, Context>, IExamDal
    {
        //public IList<ExamViewModel> GetExamViews()
        //{
        //    using (var context = new Context())
        //    {
        //        var result = from e in context.Exams
        //                     join c in context.Courses
        //                     on e.CourseId equals c.Id
        //                     join s in context.Students
        //                     on e.StudentId equals s.Id
        //                     select new ExamViewModel
        //                     {
        //                         CourseName = c.Name,
        //                         StudentName = s.FirstName + " " + s.LastName,
        //                         Midterm = e.Midterm,
        //                         Final = e.Final,
        //                     };
        //        return result.ToList();
        //    }
        //}
    }
}
