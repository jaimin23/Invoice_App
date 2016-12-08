using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    public enum TypeOfUser: byte
    {
        User = 1,
        Admin,
        Manager
    }
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public TypeOfUser UserType { get; set; }

        internal void Change(User user)
        {
            this.UserName = user.UserName;
            this.UserPassword = user.UserPassword;
            this.UserType = user.UserType;
        }
    }
}
