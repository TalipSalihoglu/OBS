using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class LecturerDal : GenericRepository<Lecturer, Context>, ILecturerDal
    {
    }
}
