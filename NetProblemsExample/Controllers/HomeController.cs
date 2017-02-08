using NetProblemsExample.Models;
using System.Web.Mvc;

namespace NetProblemsExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult StartPage()
        {
            var person = new Person();
            person.IsDone = false;

            return View(person);
        }

        [HttpPost]
        public ActionResult StartPage(Person person)
        {
            return View(person);
        }

        public ActionResult SecondPage()
        {
            var user = new UserClass();
            user.UserIsDone = false;

            return View(user);
        }

        [HttpPost]
        public ActionResult SecondPage(UserClass user)
        {
            return View(user);
        }

        public ActionResult ThirdPage()
        {
            var admin = new Administrator();
            admin.AdminIsDone = false;
            //admin.UserClass = new UserClass();

            return View(admin);
        }

        [HttpPost]
        public ActionResult ThirdPage(Administrator admin)
        {

            return View(admin);
        }
    }
}