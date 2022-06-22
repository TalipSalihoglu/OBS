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
        public Guid Id{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Email{ get; set; }
        public Address Address { get; set; }
        public DateTime CreatedDate{ get; set; }

        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
