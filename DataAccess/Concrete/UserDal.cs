using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Utilities.Jwt;
using DataAccess.Abstract;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserDal: GenericRepository<User,Context>,IUserDal
    {
    }
}
