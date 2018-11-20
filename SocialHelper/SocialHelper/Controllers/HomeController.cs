using System.Web.Mvc;

namespace SocialHelper.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Ru()
    {
      return View();
    }

    public ActionResult PrivacyPolicy()
    {
      return View();
    }
  }
}