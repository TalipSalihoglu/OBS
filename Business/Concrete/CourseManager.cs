using Business.Abstract;
using Business.FluentValidation;
using Core.CrossCuttingConcerns;
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
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;
        private readonly IStudentCourseService _studentCourseService;

        public CourseManager(ICourseDal courseDal, IStudentCourseService studentCourseService)
        {
            _courseDal = courseDal;
            _studentCourseService = studentCourseService;
        }

        public void Add(Course course)
        {
            ValidationTool.Validate(new CourseValidator(), course);
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            var course = _courseDal.Get(filter);
            course.Students = _studentCourseService.GetStudentsOfCourseByCourseId(course.Id);
            return course;
        }

        public IList<Course> GetList(Expression<Func<Course, bool>> filter = null)
        {
            return _courseDal.GetList(filter);
        }

        public void Update(Course course)
        {
            ValidationTool.Validate(new CourseValidator(), course);
            _courseDal.Update(course);
        }
    }
}
