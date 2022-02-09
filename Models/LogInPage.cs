using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LogginPage.Models.Inside
{
    public class LogInPage
    {
        [Key]
        public int ID { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Wrong Password"), Required]
        public string Password { get; set; }
    }
}