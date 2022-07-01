using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentCourseService
    {
        StudentCourse Get(Expression<Func<StudentCourse, bool>> filter);
        IList<StudentCourse> GetList(Expression<Func<StudentCourse, bool>> filter = null);
        IList<Course> GetCoursesOfStudentByStudentId(int studentId);
        IList<Student> GetStudentsOfCourseByCourseId(int courseId);
        void AddStudentToCourse(StudentCourse studentCourse);
        void Update(StudentCourse studentCourse);
        void Delete(StudentCourse studentCourse);
    }
}
