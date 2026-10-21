using CityTech.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityTech.Web.Controllers;

[Route("services")]
public class ServicesController : Controller
{
    [HttpGet("app-development")]
    public IActionResult AppDevelopment() => Detail("app-development");

    [HttpGet("web-development")]
    public IActionResult WebDevelopment() => Detail("web-development");

    [HttpGet("cost-management")]
    public IActionResult CostManagement() => Detail("cost-management");

    [HttpGet("maintainance-support")]
    public IActionResult Maintainance() => Detail("maintainance-support");

    [HttpGet("warranty-management")]
    public IActionResult WarrantyManagement() => Detail("warranty-management");

    private IActionResult Detail(string slug)
    {
        var service = ServiceData.Get(slug);
        if (service is null) return NotFound();
        return View("Detail", service);
    }
}
