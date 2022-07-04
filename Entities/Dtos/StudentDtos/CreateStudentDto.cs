using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.StudentDtos
{
    public class CreateStudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public string FullAddress { get; set; }
        public int DepartmentId { get; set; }
        public int UserId { get; set; }
    }
}
