using RadarcOnline.App.Presentation.Mvc.Extensions.Controllers;
using System.Web.Mvc;

namespace RadarcOnline.App.Presentation.Mvc.Controllers
{
    public partial class HomeController : BaseController
    {
        public ActionResult Index()
        {
			return RedirectToAction("MainPage", "Recipe");
        }

        public ActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

