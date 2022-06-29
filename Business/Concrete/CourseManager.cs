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

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
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
           return _courseDal.Get(filter);
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
