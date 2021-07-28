using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpSalaryCal.Models
{
    public class Dependent
    {
        [Required(ErrorMessage ="Required")]
        [Display(Name = "Enter the Number Of Dependents")]
        
        public int NumberOfDependent { get; set; }
    }
}
