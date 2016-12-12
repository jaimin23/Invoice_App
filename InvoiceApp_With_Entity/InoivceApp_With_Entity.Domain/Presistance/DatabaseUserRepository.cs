using InoivceApp_With_Entity.Domain.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    /// <summary>
    /// This class is responsible for loading up the user data into an IEnumerable list 
    /// type user and also contaisn the save functionality which saves new users
    /// </summary>
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
        /// <summary>
        /// This method saves and updates the user information based on the user object passed
        /// </summary>
        /// <param name="user"></param>
        public void SaveUser(User user)
        {
            if(user.UserId == 0)
            {
                _dbContext.Users.Add(user);
            }
            else
            {
                User userEntity = _dbContext.Users.Find(user.UserName);
                userEntity.Change(user);
            }
            _dbContext.SaveChanges();
        }
    }
}
