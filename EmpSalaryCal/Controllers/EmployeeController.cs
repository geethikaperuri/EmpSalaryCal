using EmpSalaryCal.Models;
using EmpSalaryCal.ServiceLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpSalaryCal.Controllers
{
    public class EmployeeController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Dependent model)
        {
            if (!ModelState.IsValid)
                return View();
            //if (model.NumberOfDependent <= 0)
            //{
            //    ModelState.AddModelError("NumberOfDependent", "Value must be grater than zero");
            //    return View();
            //}
            return RedirectToAction("Calculate", new { id = model.NumberOfDependent });
        }

        [HttpGet]
        public IActionResult Calculate(int id)
        {
           
                ViewBag.TotalPayablePerYear = string.Empty;
            ViewBag.TotalPay = string.Empty;
            var model = new EmployeeDeduction
            {
                IsDependent = false,
                Dependent = new List<EmployeeDeduction>()
            };
            for (int i = 1; i <= id; i++)
            {
                model.Dependent.Add(new EmployeeDeduction { IsDependent = true });
            }
            return View(model);
        }
      
        [HttpPost]
        public IActionResult Calculate(EmployeeDeduction model)
        {
           
            decimal beforeDeductions = 2000.00m;
            int paychecks = 26;
            decimal totalPayablePerYear = beforeDeductions * paychecks;
            ViewBag.TotalPay = $"Employee Annual Pay is ${totalPayablePerYear}";
            BasePayrollFactory _factory;
            _factory = new ManageEmployeeFactory().GetObject(model);
            _factory.ApplyeDeduction();
            totalPayablePerYear -= model.DeductionAmount;
            if (model.Dependent.Count > 0)
            {
                for (int i = 0; i < model.Dependent.Count; i++)
                {
           
                    _factory = new ManageEmployeeFactory().GetObject(model.Dependent[i]);
                    _factory.ApplyeDeduction();
                    totalPayablePerYear -= model.Dependent[i].DeductionAmount;
                }
            }
            ViewBag.TotalPayablePerYear= $"After all deductions Employee Pay is ${totalPayablePerYear}";
            return View(model);
        }
    }
}
