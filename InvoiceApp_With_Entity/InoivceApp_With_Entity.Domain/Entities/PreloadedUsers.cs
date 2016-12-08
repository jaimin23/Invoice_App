using InoivceApp_With_Entity.Domain.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    class PreloadedUsers : IPreloadedUsers
    {
        private IUserRepository _userRepository;
        public IEnumerable<User> UserList { get; }

        public PreloadedUsers(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            this.UserList = _userRepository.Users;
        }
        public void SaveUser(User user)
        {
            _userRepository.SaveUser(user);
        }
    }
}
