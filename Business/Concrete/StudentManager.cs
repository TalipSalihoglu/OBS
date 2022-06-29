using Business.Abstract;
using Business.FluentValidation;
using Core.CrossCuttingConcerns;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public void Add(Student student)
        {
            student.CreatedDate= DateTime.Now;
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Add(student);
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public Student Get(Expression<Func<Student, bool>> filter)
        {
            return _studentDal.Get(filter);
        
        }

        public IList<Student> GetList(Expression<Func<Student, bool>> filter = null)
        {
            return _studentDal.GetList(filter);
        }

        public void Update(Student student)
        {
            ValidationTool.Validate(new StudentValidator(), student);
            _studentDal.Update(student);
        }
    }
}
