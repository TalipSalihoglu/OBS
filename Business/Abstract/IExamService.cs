using Entities.Concrete;
using Entities.Dtos.ExamDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IExamService
    {
        Exam Get(Expression<Func<Exam, bool>> filter);
        IList<Exam> GetList(Expression<Func<Exam, bool>> filter = null);
        IList<Exam> GetAllExamByStudentId(int studentId);
        IList<Exam> GetAllExamByCourseId(int courseId);
        IList<Exam> GetExamByStudentIdAndCourseId(int studentId, int CourseId);
        void Add(Exam exam);
        void Update(Exam exam);
        void Delete(Exam exam);
        

    }
}
