using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    { return View(); }
  }
}