using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class StudentCourse
    {
        public int Id{ get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
