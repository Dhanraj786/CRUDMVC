using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDPRACTICAL.Models
{
    public class Login
    {
        [DisplayName("Email Address")]
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter The Email Address")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter The Password")]
        public string Password { get; set; }

       
    }
}
