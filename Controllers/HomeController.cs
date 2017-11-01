using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
          List<Contact> allContacts = Contact.GetAll();
          return View(allContacts);
        }

        [HttpGet("/NewContact")]
        public ActionResult NewContact()
        {
          return View();
        }

        [HttpPost("/AddConfirm")]
        public ActionResult AddConfirm()
        {
          Contact myContact = new Contact(Request.Form["name"], Request.Form["address"], Request.Form["phone"]);
          myContact.Save();
          return View(myContact);
        }

        [HttpPost("/DeleteConfirm")]
        public ActionResult DeleteConfirm()
        {
          Contact.ClearAll();
          return View();
        }

        [HttpGet("/contact/{id}")]
        public ActionResult ContactDetail(int id)
        {
          Contact detail = Contact.Find(id);
          return View(detail);
        }
    }
}
