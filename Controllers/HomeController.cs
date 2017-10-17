using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [Produces("text/html")]
        [Route("/")]
        public ActionResult Index()
        {
          return View();
        }

        [Produces("text/html")]
        [Route("/NewContact")]
        public ActionResult NewContact()
        {
          return View();
        }

        [Produces("text/html")]
        [Route("/AddConfirm")]
        public ActionResult AddConfirm()
        {
          Contact myContact = new Contact();
          myContact.SetName(Request.Query["name"]);
          myContact.SetAddress(Request.Query["address"]);
          myContact.SetPhone(Request.Query["phone"]);
          return View(myContact);
        }

        [Produces("text/html")]
        [Route("/DeleteConfirm")]
        public ActionResult DeleteConfirm()
        {
          return View();
        }
    }
}
