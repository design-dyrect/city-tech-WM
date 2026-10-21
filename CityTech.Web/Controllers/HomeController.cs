using Microsoft.AspNetCore.Mvc;

namespace CityTech.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}
