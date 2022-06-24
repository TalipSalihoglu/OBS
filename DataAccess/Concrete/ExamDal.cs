using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class ExamDal : GenericRepository<Exam, Context>, IExamDal
    {

    }
}
