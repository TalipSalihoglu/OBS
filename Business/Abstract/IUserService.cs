using Core.Entities.Concrete;
using Core.Utilities.Jwt;
using Entities.Concrete;
using Entities.Dtos.LoginDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        User Get(Expression<Func<User, bool>> filter);
        void Add(User user);
        string Login(LoginDto loginDto);
    }
}
