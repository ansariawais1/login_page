using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LogginPage.Models
{
    public class SignUp
    {
        public int ID { get; set; }

        [Remote("IsUserNameAvailable", "AccountController", ErrorMessage = "User Name Already Exists.")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        
        [DataType(DataType.Password,ErrorMessage ="Wrong Type"),Required]
        public string Password { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Gender { get; set; }





    }
}