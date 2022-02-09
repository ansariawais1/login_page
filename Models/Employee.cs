using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogginPage.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        [Display(Name ="Employee Name")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Salary { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required]
        public DateTime DOB { get; set; }


        [Display(Name = "Date Of Joining")]
        [Required]
        public DateTime DOJ { get; set; }

        [Display(Name = "Department Name")]
        [Required]
        public string Department { get; set; }



        [Required]
        public String Gender { get; set; }

     


    }
}