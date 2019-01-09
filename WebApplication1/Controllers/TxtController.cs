using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class TxtController : Controller
    {
        // GET: Txt
        public ActionResult GetView()
        {
            //Employee emp = new Employee();
            //emp.Name = "威廉. 莎士比亚";
            //ViewBag.empKey = emp;
            //return View(emp);

            Customer ct= new Customer();
            ct.CustomerName = "张三";
            ct.Address = "打手";

            Employee emp = new Employee();
            emp.Name = "李四";
            emp.Salary = 2000;

            EmCu emCu = new EmCu();
            emCu.CustomerInfo = ct;
            emCu.EmployeeInfo = emp;
            return View("View2,emCu");
            

        }

    }
}