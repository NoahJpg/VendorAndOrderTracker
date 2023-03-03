using VenderAndOrderTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace VenderAndOrderTracker.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Letter() 
    {
      return View();
    }
  }
}