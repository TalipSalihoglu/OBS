using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class LecturetDal : GenericRepository<Lecturer, Context>, ILecturerDal
    {
    }
}
