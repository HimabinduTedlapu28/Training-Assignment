using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using codebased8_1_.Models; 

namespace codebased8_1_.Controllers
{
    public class codeController : Controller
    {
        public NorthwindEntities Entities = new NorthwindEntities();
         
        // GET: code
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomersGermany()
        {
            var cust = Entities.Customers.Where(g => g.Country == "Germany");
            return View(cust);
        }
        
        public ActionResult orderid()
        {
            var customerId = Entities.Customers.FirstOrDefault(od => od.OrderID == 10248)?.Order.CustomerID;
            var customerDetails = Entities.Customers.FirstOrDefault(c => c.CustomerID == customerId);
            return View(customerDetails);
        }

    }
}