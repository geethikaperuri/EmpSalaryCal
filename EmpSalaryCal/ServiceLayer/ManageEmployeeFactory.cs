using EmpSalaryCal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpSalaryCal.ServiceLayer
{
    public class ManageEmployeeFactory
    {
        public BasePayrollFactory GetObject(EmployeeDeduction employeeDeduction)
        {
            BasePayrollFactory returnValue = null;
            if (employeeDeduction.IsDependent)
            {
                returnValue = new DependentDeductionFactory(employeeDeduction);
            }
            else
            {
                returnValue = new EmployeeDeductionFactory(employeeDeduction);
            }
            return returnValue;
        }
    }
}
