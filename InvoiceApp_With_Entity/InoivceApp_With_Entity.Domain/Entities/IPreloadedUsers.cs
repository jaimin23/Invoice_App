using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    public interface IPreloadedUsers
    {
        IEnumerable<User> UserList { get; }

        void SaveUser(User user);
    }
}
