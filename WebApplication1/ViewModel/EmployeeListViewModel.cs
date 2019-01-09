using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModel
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> EmployeeViewList { get; set; }
        public string UserName { get; set; }
        public string Greeting { get; set; }
    }

}