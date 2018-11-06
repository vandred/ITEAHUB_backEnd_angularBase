using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngularIteaBack.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "LoginName is Required")]
        public string LoginName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        public string Roles { get; set; }
    }
}
