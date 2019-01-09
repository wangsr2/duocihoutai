using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

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
            ct.Adddress = "anaa";
            return ct;
            
        }
    }
}