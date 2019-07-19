using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Students.Web.Models;

namespace Students.Web.Controllers
{
    public class UserController : Controller
    {
        private static readonly List<UserViewModel> Users = new List<UserViewModel>
        {
            new UserViewModel { Id = 1, Email = "dan@yahoo.com", UserName = "dan" },
            new UserViewModel { Id = 2, Email = "andrei@yahoo.com", UserName = "andrei" },
            new UserViewModel { Id = 3, Email = "vlad@yahoo.com", UserName = "vlad" },
        };

        [HttpGet]
        public ActionResult Index()
        {
            return View(Users);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = Users.FirstOrDefault(x => x.Id == id);

            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(UserViewModel user)
        {
            Users.Add(user);

            return RedirectToAction("Index");
        }
    }
}