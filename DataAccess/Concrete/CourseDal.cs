using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class CourseDal : GenericRepository<Course, Context>, ICourseDal
    {
    }
}
