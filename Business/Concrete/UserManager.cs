using Business.Abstract;
using Business.FluentValidation;
using Core.CrossCuttingConcerns;
using Core.Entities.Concrete;
using Core.Utilities.Jwt;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.LoginDtos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IConfiguration _config;
        private readonly IJwtUtils _jwtUtils;

        public UserManager(IUserDal userDal, IConfiguration config, IJwtUtils jwtUtils)
        {
            _userDal = userDal;
            _config = config;
            _jwtUtils = jwtUtils;
        }

        public void Add(User user)
        {
            var result = _userDal.Get(x=>x.UserName== user.UserName);
            if (result != default)
                throw new InvalidOperationException("User name already exist");

            ValidationTool.Validate(new UserValidator(), user);
            _userDal.Add(user);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
           var user =_userDal.Get(filter);
            if (user is null)
                throw new InvalidOperationException("User not found");
            return user;
        }

        public string Login(LoginDto loginDto)
        {
            var user = _userDal.Get(x => x.UserName.Equals(loginDto.Username) && x.Password.Equals(loginDto.Password));

            if(user is null)
                throw new InvalidOperationException("Wrong username or password");

            var jwtToken = _jwtUtils.GenerateJwtToken(user);

            return jwtToken;
        } 

        
    }
}
