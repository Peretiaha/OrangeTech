using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.BLL.Interfaces
{
    public interface IUserService : IService<User>
    {
        bool Login(User user);

        User GetUserById(Guid userId);

        User GetUserByEmail(string email);
    }
}
