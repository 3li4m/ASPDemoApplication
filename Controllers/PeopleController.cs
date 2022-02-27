using ASPDemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDemoApplication.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople() 
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { firstName = "tim", lastName = "long", age = 25, isAlive = true });
            people.Add(new PersonModel { firstName = "simon", lastName = "smith", age = 32, isAlive = true });
            people.Add(new PersonModel { firstName = "dom", lastName = "andrews", age = 20, isAlive = true });


            // Returns the view and passes back the people object (or any object you would want to pass back to the page)
            return View(people);
        }
    }
}