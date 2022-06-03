using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }                     //Model Requred Field //Change Employee Name
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage =("Employee Name can't Empty"))]
        [MinLength(5, ErrorMessage = " Name Must be Min  5 Char  ")]        
        [MaxLength(15, ErrorMessage = " Name Must be Min  15 Char  ")]
        public string Name { get; set; }

        [Display(Name="Employee Email")]
        [Required(ErrorMessage = ("Employee Email can't Empty"))]
        [MinLength(10, ErrorMessage = " Email Must be Min  10 Char  ")]
        [MaxLength(30, ErrorMessage = " Email Must be Min  30 Char  ")]
        public string Email { get; set; }

        [Display(Name = "Employee Gander")]
        [Required(ErrorMessage = ("Employee Gander can't Empty"))]
        [MinLength(2, ErrorMessage = " Gander Must be Min  1 Char  ")]
        [MaxLength(4, ErrorMessage = " Gander Must be Min  4 Char  ")]
        public string Gander { get; set; }
        [Display(Name = "Employee Address")]
        [Required(ErrorMessage = ("Employee Address can't Empty"))]
        [MinLength(50, ErrorMessage = " Address Must be Min  50 Char  ")]
        [MaxLength(100, ErrorMessage = " Address Must be Min  100 Char  ")]
        public string Address { get; set; }
    }
}
