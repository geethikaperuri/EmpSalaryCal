using EmpSalaryCal.Manage;
using EmpSalaryCal.Models;
using EmpSalaryCal.ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpSalaryCal.ServiceLayer
{
    public class EmployeeDeductionFactory : BasePayrollFactory
    {

        public EmployeeDeductionFactory(EmployeeDeduction empdeduction) : base(empdeduction)
        {
        }
        public override IEmployeeManager Create()
        {
            var _deduction = new ManageEmployeeDeduction();
            _empdeduction.DeductionAmount = _deduction.getDeduction(_empdeduction.Name);
            return _deduction;
        }

    }
}
