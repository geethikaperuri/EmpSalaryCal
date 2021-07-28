using EmpSalaryCal.ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpSalaryCal.Manage
{
    public class ManageEmployeeDeduction : IEmployeeManager
    {

        public decimal getDeduction(string name)
        {
            
            decimal deduction = 1000.00m;
            if (name.StartsWith("a", StringComparison.OrdinalIgnoreCase))
            {
                deduction -= (10m / 100m) * 1000m;
            }
            return deduction;
        }
    }
}
