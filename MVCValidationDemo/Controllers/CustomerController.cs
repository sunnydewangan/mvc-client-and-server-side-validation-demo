using CustomerManagement.Models;
using System.Web.Mvc;

namespace CustomerManagement.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Display()
        {
            return View(new Customer());  //When the user browses the Display page directly from the browser
        }

        [HttpPost]
        public ActionResult Submit(Customer customer)
        {
            if (ModelState.IsValid)   //Server side validation check
            {
                return View("Display", customer);
            }
            else
            {
                return View("Add");
            }
        }
    }
}