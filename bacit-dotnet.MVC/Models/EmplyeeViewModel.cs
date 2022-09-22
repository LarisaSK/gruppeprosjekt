using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace bacit_dotnet.MVC.Models.Employee
{
    public class EmplyeeViewModel
    {
        [Required (ErrorMessage ="Ansatt ID er et obligatorisk felt")]
        [Display (Name ="Ansatt ID")]
        [MinLength(7)]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Navn er et obligatorisk felt")]
        [Display(Name = "Navn")]
        public string EmpName { get; set; }
      
        [Required(ErrorMessage = "Team ID er et obligatorisk felt")]
        [Display(Name ="Gruppe ID")]
        public int TeamId { get; set; }
        


    }
}
