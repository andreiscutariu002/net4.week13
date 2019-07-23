using System.Web.Mvc;
using Students.Web.Models;

namespace Students.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new UserViewModel() { Email = "andrei@yahoo.com", UserName = "andrei"  };

            return View(model);
        }
    }
}