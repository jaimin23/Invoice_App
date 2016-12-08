using InoivceApp_With_Entity.Domain.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    class DatabaseUserRepository : IUserRepository
    {
        private InvoiceDbContext _dbContext;

        public DatabaseUserRepository()
        {
            _dbContext = new InvoiceDbContext();
        }
        public IEnumerable<User> ListOfUsers
        {
            get
            {
                return _dbContext.Users;
            }
        }

        public void SaveUser(User user)
        {
            if(user.UserId == 0)
            {
                _dbContext.Users.Add(user);
            }
            else
            {
                User userEntity = _dbContext.Users.Find(user.UserId);
                userEntity.Change(user);
            }
            _dbContext.SaveChanges();
        }
    }
}
