using EmpSalaryCal.Manage;
using EmpSalaryCal.Models;
using EmpSalaryCal.ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpSalaryCal.ServiceLayer
{
    public class DependentDeductionFactory : BasePayrollFactory
    {
        public DependentDeductionFactory(EmployeeDeduction empdeduction) : base(empdeduction)
        {
        }
        public override IEmployeeManager Create()
        {
            var _deduction = new ManageDependentDeduction();
            _empdeduction.DeductionAmount = _deduction.getDeduction(_empdeduction.Name);
            return _deduction;
        }
    }
}
