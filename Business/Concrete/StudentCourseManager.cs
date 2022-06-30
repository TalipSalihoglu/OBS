using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentCourseManager : IStudentCourseService
    {
        private readonly IStudentCourseDal _studentCourseDal;
        private readonly IStudentDal _studentDal;
        private readonly ICourseDal _courseDal;

        public StudentCourseManager(IStudentCourseDal studentCourseDal, IStudentDal studentDal, ICourseDal courseDal)
        {
            _studentCourseDal = studentCourseDal;
            _studentDal = studentDal;
            _courseDal = courseDal;
        }

        public void Add(StudentCourse studentCourse)
        {
            _studentCourseDal.Add(studentCourse);
        }

        public void Delete(StudentCourse studentCourse)
        {
            throw new NotImplementedException();
        }

        public StudentCourse Get(Expression<Func<StudentCourse, bool>> filter)
        {
            return _studentCourseDal.Get(filter);
        }

        public IList<Course> GetCoursesOfStudentByStudentId(int studentId)
        {
            var list = _studentCourseDal.GetList(x => x.StudentId == studentId).Select(x=>x.CourseId);
            var courses = _courseDal.GetList(x => list.Contains(x.Id));
            return courses;
        }

        public IList<StudentCourse> GetList(Expression<Func<StudentCourse, bool>> filter = null)
        {
            return _studentCourseDal.GetList(filter);
        }

        public IList<Student> GetStudentsOfCourseByCourseId(int courseId)
        {
            var list = _studentCourseDal.GetList(x => x.CourseId == courseId).Select(x => x.StudentId);
            var students =_studentDal.GetList(x => list.Contains(x.Id));
            return students;
        }

        public void Update(StudentCourse studentCourse)
        {
            _studentCourseDal.Update(studentCourse);
        }
    }
}
