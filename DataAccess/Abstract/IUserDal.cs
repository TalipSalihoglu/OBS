using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Utilities.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal : IGenericRepository<User>
    {
    }
}
