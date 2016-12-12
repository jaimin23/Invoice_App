using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    /// <summary>
    /// This enum type User contains the type of user that a person could be assigned to
    /// </summary>
    public enum TypeOfUser: byte
    {
        User = 1,
        Admin,
        Manager
    }
    public class User
    {
        /// <summary>
        /// This property gets and sets the UserId
        /// </summary>
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// This property gets and sets the user name
        /// </summary>
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// Thie property gets and sets the user password
        /// </summary>
        [Required]
        public string UserPassword { get; set; }

        /// <summary>
        /// This propert gets and set the User type
        /// </summary>
        [Required]
        public TypeOfUser UserType { get; set; }

        /// <summary>
        /// This method updates the information for the an existing user
        /// </summary>
        /// <param name="user"></param>
        internal void Change(User user)
        {
            this.UserName = user.UserName;
            this.UserPassword = user.UserPassword;
            this.UserType = user.UserType;
        }
    }
}
