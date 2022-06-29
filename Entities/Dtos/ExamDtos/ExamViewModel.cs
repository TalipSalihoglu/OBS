using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.ExamDtos
{
    public class ExamViewModel
    {
        public string CourseName{ get; set; }
        public string StudentName{ get; set; }
        public decimal Midterm { get; set; }
        public decimal Final { get; set; }

    }
}
