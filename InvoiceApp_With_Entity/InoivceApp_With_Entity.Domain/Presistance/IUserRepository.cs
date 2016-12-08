using InoivceApp_With_Entity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Presistance
{
    public interface IUserRepository
    {
        IEnumerable<User> ListOfUsers { get; }
        void SaveUser(User user);
    }
}
