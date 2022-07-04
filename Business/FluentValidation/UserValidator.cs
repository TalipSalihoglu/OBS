using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.FluentValidation
{
    public class UserValidator :AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x=>x.UserName).NotEmpty().MinimumLength(3);
            RuleFor(x=>x.Password).NotEmpty().MinimumLength(3);
            RuleFor(x=>x.RoleId).NotEmpty();
        }
    }
}
