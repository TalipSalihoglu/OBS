using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class ExamValidator :AbstractValidator<Exam>
    {
        public ExamValidator()
        {
            RuleFor(x => x.CourseId).NotNull().GreaterThan(0);
            RuleFor(x => x.StudentId).NotNull().GreaterThan(0);
            RuleFor(x => x.Midterm).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Final).GreaterThanOrEqualTo(0);

        }
    }
}
