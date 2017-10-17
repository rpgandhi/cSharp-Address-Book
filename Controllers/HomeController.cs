using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/NewContact")]
        public ActionResult NewContact()
        {
          return View();
        }


        [HttpPost("/AddConfirm")]
        public ActionResult AddConfirm()
        {
          Contact myContact = new Contact(Request.Query["name"], Request.Query["address"], Request.Query["phone"]);
          return View(myContact);
        }


        [HttpPost("/DeleteConfirm")]
        public ActionResult DeleteConfirm()
        {
          return View();
        }
    }
}
