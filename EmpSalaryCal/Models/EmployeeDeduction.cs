using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpSalaryCal.Models
{
    public class EmployeeDeduction
    {
        public EmployeeDeduction()
        {
            Dependent = new List<EmployeeDeduction>();
        }
        public decimal DeductionAmount { get; set; } = 0;
        public bool IsDependent { get; set; } = false;

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = " Name is required field ")]
        public string Name { get; set; }

        public string DependentName { get; set; }
        [Display(Name = "No Of Dependents")]
        public int NoOfDependents { get; set; }

        public List<EmployeeDeduction> Dependent { get; set; }
      
    }
}
