using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Models
{
    public class Users
    {
        [Key]
        public long LoginId { get; set; }
        [Required(ErrorMessage = "User Id is mendatory.")]
        public long UserId { get; set; }

        [Required(ErrorMessage = "Type is mendatory.")]
        public string UserType { get; set; }

        [Required(ErrorMessage = "Password is mendatory.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "First name is mendatory.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is mendatory.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
        ErrorMessage = "Scary Email.")]
        public string Email { get; set; }
    }
}
