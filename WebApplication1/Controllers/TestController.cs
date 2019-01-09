using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public string GetString()
        {
            return "测试测试！";
        }
        public Customer getCustomer()
        {
            Customer ct = new Customer();
            ct.CustomerName = "bbb";
            ct.Address = "anaa";
            return ct;
        }
        //public ActionResult GetView()
        //{
        //    Employee emp = new Employee();
        //    emp.Name = "李四";
        //    emp.Salary = 2000;
        //    EmployeeViewModel vmEmp = new EmployeeViewModel();
        //    vmEmp.EmployeeName = emp.Name;
        //    vmEmp.Salary = emp.Salary.ToString("C");
        //    if (emp.Salary > 1000)
        //    {
        //        vmEmp.SalaryGrade = "土豪";
        //    }
        //    else
        //    {
        //        vmEmp.SalaryGrade = "屌丝";
        //    }
        //    vmEmp.UserName = "Admin";
        //    return View("MyView", vmEmp);
            
        
        //}
    }

}