using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interface
{
    public interface ITokenService
    {
       public  string CreateToken(AppUser user);
    }
}