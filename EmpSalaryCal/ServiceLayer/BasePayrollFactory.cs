using EmpSalaryCal.Models;
using EmpSalaryCal.ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpSalaryCal.ServiceLayer
{
    public abstract class BasePayrollFactory
    {
        protected EmployeeDeduction _empdeduction;

        protected BasePayrollFactory(EmployeeDeduction empdeduction)
        {
            _empdeduction = empdeduction ?? throw new ArgumentNullException(nameof(empdeduction));
        }
        public abstract IEmployeeManager Create();

        public virtual EmployeeDeduction ApplyeDeduction()
        {
            IEmployeeManager manager = this.Create();
            _empdeduction.DeductionAmount = manager.getDeduction(_empdeduction.Name);
            return _empdeduction;
        }
    }
}
