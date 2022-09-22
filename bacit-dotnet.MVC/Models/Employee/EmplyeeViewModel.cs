using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace bacit_dotnet.MVC.Models.Employee
{
    public class EmplyeeViewModel
    {
        [Required (ErrorMessage ="Employee ID is required")]
        [Display (Name ="Ansatt ID")]
        [MinLength(7)]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name ID is required")]
        [Display(Name = "Navn")]
        public string EmpName { get; set; }
      
        [Required(ErrorMessage = "Team ID is required")]
        [Display(Name ="Lag ID")]
        public int TeamId { get; set; }
        


    }
}
