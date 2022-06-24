using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class StudentDal : GenericRepository<Student, Context>, IStudentDal
    {
        public Student GetStudentDetail(Expression<Func<Student, bool>> filter)
        {
            using (var context = new Context())
            {
                return context.Students
                    .Include(co=>co.Courses)
                    .Include(de=>de.Department)
                    .SingleOrDefault(filter);
            }

        }
    }
}
