using Microsoft.AspNetCore.Mvc;

namespace IdentityRoles.Controllers 
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}