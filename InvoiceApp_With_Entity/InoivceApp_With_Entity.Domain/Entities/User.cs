using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required]
        public TypeOfUser UserType { get; set; }

        internal void Change(User user)
        {
            this.UserName = user.UserName;
            this.UserPassword = user.UserPassword;
            this.UserType = user.UserType;
        }
    }
}
