using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        Student Get(Expression<Func<Student, bool>> filter);
        Student GetDetail(Expression<Func<Student, bool>> filter);
        IList<Student> GetList(Expression<Func<Student, bool>> filter = null);
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}
