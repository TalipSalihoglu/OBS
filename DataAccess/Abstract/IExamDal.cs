using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos.ExamDtos;

namespace DataAccess.Abstract
{
    public interface IExamDal : IGenericRepository<Exam>
    {
    }
}
