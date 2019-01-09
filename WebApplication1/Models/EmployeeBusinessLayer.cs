using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataAccessLayer;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployeeList()
        {
            SalesERPDAL salesDal = new SalesERPDAL();

            return salesDal.infoM.ToList();
            //var list = new List<Employee>();
            //Employee emp = new Employee();
            //emp.Name = "东北虎";
            //emp.Salary = 111100;
            //list.Add(emp);

            //Employee emp = new Employee();
            //emp.Name = "东北虎";
            //emp.Salary = 111100;
            //list.Add(emp);
            //return list;
        }
    }
}