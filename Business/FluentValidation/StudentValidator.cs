using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(3);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(2);
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
            RuleFor(x => x.StudentNo).NotNull();
            RuleFor(x => x.FullAddress).NotEmpty().MinimumLength(6);
            RuleFor(x => x.DepartmentId).NotNull().GreaterThan(0);
            RuleFor(x => x.CityId).NotNull().GreaterThan(0);
        }
    }
}
