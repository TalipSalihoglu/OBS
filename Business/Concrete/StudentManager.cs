using Business.Abstract;
using Business.FluentValidation;
using Core.CrossCuttingConcerns;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;
        private readonly IStudentCourseService _studentCourseService;
        private readonly IExamService _examService;
        public StudentManager(IStudentDal studentDal, IStudentCourseService studentCourseService, IExamService examService)
        {
            _studentDal = studentDal;
            _studentCourseService = studentCourseService;
            _examService = examService;
        }
        public void Add(Student student)
        {
            student.CreatedDate= DateTime.Now;
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Add(student);
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public Student Get(Expression<Func<Student, bool>> filter)
        {
            var student = _studentDal.Get(filter);
            if (student is null)
                throw new Exception("Student not found"); 
            student.Courses= _studentCourseService.GetCoursesOfStudentByStudentId(student.Id);
            var coursesIdList=student.Courses.Select(c => c.Id).ToList();
            student.ExamList= new List<Exam>();
            foreach (var item in coursesIdList)
            {
                student.ExamList.Add(_examService.GetExamByStudentIdAndCourseId(student.Id,item));
            }
            return student;
        
        }

        public IList<Student> GetList(Expression<Func<Student, bool>> filter = null)
        {
            return _studentDal.GetList(filter);
        }

        public void Update(Student student)
        {
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Update(student);
        }
    }
}
