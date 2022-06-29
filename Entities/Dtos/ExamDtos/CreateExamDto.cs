using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.ExamDtos
{
    public class CreateExamDto
    {
        public decimal Midterm { get; set; }
        public decimal Final { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
