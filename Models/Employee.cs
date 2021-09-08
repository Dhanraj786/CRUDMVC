using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDPRACTICAL.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Please Enter The FullName.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [Required(ErrorMessage = "Please Enter The EmpCode.")]
        [DisplayName("Emp Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Selected a Position.")]

        [DisplayName("Position")]
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter The Office Location")]


        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }

        [Column(TypeName = "varchar(07)")]

        [DisplayName("Gender")]
        public string Gender { get; set; }

        [DisplayName("Email Address")]
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter The Email Address")]
        public string Email { get; set; }
       
        [DisplayName("Password")]
        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Please Enter The Password")]
        public string Password {get; set; }

        /*  [DisplayName("Conform Password")]
          [Column(TypeName = "varchar(100)")]
          [Required(ErrorMessage = "Please Conform The Password")]
          [Compare("Password")]
          public string ConfirmPassword { get; set; }*/

    }
}


    

