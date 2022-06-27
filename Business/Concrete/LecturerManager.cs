using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LecturerManager : ILecturerService
    {
        private readonly ILecturerDal _lecturerDal;
        private readonly ICourseDal _coursesDal;

        public LecturerManager(ILecturerDal lecturerDal, ICourseDal coursesDal)
        {
            _lecturerDal = lecturerDal;
            _coursesDal = coursesDal;
        }

        public void Add(Lecturer lecturer)
        {
            _lecturerDal.Add(lecturer);
        }

        public void Delete(Lecturer lecturer)
        {
            throw new NotImplementedException();
        }

        public Lecturer Get(Expression<Func<Lecturer, bool>> filter)
        {
            var lecturer = _lecturerDal.Get(filter);
            lecturer.Courses = _coursesDal.GetList(x => x.LecturerId == lecturer.Id);
            return lecturer;
        }

        public IList<Lecturer> GetList(Expression<Func<Lecturer, bool>> filter = null)
        {
            var lecturerList = _lecturerDal.GetList(filter);
            foreach (var lecturer in lecturerList)
            {
                lecturer.Courses = _coursesDal.GetList(x => x.LecturerId == lecturer.Id);
            }

            return lecturerList;
        }

        public void Update(Lecturer lecturer)
        {
            _lecturerDal.Update(lecturer);
        }
    }
}
