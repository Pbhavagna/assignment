using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codetest8.Controllers
{
    public class code8_Controller : Controller
    {
        // GET: code8_
        private NorthwindEntities db = new NorthwindEntities();
        public ActionResult CustomersInGermany()
        {
            var germanyCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanyCustomers);
        }
        public ActionResult CustomerDetailsWithOrderId()
        {
            var customerDetails = db.Orders
                .Where(o => o.OrderID == 10248)
                .Select(o => o.Customer)
                .FirstOrDefault();

            return View(customerDetails);
        }
    }
}