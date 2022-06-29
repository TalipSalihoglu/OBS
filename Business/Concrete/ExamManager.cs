using Business.Abstract;
using Business.FluentValidation;
using Core.CrossCuttingConcerns;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.ExamDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ExamManager : IExamService
    {
        private readonly IExamDal _examDal;
        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }

        public void Add(Exam exam)
        {
            ValidationTool.Validate(new ExamValidator(), exam);
            _examDal.Add(exam);
        }

        public void Delete(Exam exam)
        {
            throw new NotImplementedException();
        }

        public IList<Exam> GetAllExamByStudentId(int studentId)
        {
            return _examDal.GetList(x => x.StudentId == studentId);

        }
        public IList<Exam> GetAllExamByCourseId(int courseId)
        {
            return _examDal.GetList(x => x.CourseId == courseId);
        }
        public IList<Exam> GetExamByStudentIdAndCourseId(int studentId,int CourseId)
        {
            return _examDal.GetList(x => x.StudentId == studentId && x.CourseId == CourseId);
        }
        public void Update(Exam exam)
        {
            ValidationTool.Validate(new ExamValidator(), exam);
            _examDal.Update(exam);
        }

        public Exam Get(Expression<Func<Exam, bool>> filter)
        {
            return _examDal.Get(filter);
        }

        public IList<Exam> GetList(Expression<Func<Exam, bool>> filter = null)
        {
            return _examDal.GetList(filter);
        }
      
    }
}
