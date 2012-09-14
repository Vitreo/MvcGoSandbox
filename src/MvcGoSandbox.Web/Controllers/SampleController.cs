using System.Web.Mvc;

namespace MvcGoSandbox.Web.Controllers
{
    public class SampleController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id, string username, string firstName, string lastName, string address1,
                                   string address2, string city, string state, string zip)
        {
            var user = new User
                {
                    Id = id,
                    Username = username,
                    FirstName = firstName,
                    LastName = lastName,
                    Address1 = address1,
                    Address2 = address2,
                    City = city,
                    State = state,
                    Zip = zip
                };
            return RedirectToAction("Index");
        }
    }
}

