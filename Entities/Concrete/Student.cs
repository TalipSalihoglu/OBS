using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student: IEntity
    {
        public int Id{ get; set; }
        public int StudentNo { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Email{ get; set; }
        public int CityId { get; set; }
        public string FullAddress { get; set; }
        public DateTime CreatedDate{ get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        //public virtual ICollection<Course> Courses { get; set; }
    }
}
