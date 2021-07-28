using EmpSalaryCal.ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpSalaryCal.Manage
{
    public class ManageDependentDeduction : IEmployeeManager
    {
        public decimal getDeduction(string name)
        {
            
                decimal deduction = 500.00m;
                if (name.ToLower().StartsWith("a"))
                {
                    deduction -= (10m / 100m) * 500m;
                }
                return deduction;
           
        }

    }
}
