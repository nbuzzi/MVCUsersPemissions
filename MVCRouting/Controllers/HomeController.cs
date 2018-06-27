namespace MVCRouting.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using MVCRouting.Models;

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            if (Session["User"] is UserViewModel user
                && user.Views.FirstOrDefault(m => m.Equals("About")) != null)
            {
                return View();
            }

            return View("~/Views/Home/Error.cshtml");
        }

        [HttpPost]
        public ActionResult Login(UserViewModel userViewModel)
        {
            if(userViewModel.Name.Equals("admin") && userViewModel.Password.Equals("1234"))
            {
                userViewModel.Views.Add("About");
                Session["User"] = userViewModel;

                return RedirectToAction("About");
            }

            return Json("Wrong user/password");
        }
    }
}