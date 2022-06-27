using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        Course Get(Expression<Func<Course, bool>> filter);
        IList<Course> GetList(Expression<Func<Course, bool>> filter = null);
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}
