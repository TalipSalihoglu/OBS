using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILecturerService 
    {
        Lecturer Get(Expression<Func<Lecturer, bool>> filter);
        IList<Lecturer> GetList(Expression<Func<Lecturer, bool>> filter = null);
        void Add(Lecturer lecturer);
        void Update(Lecturer lecturer);
        void Delete(Lecturer lecturer);

    }
}
