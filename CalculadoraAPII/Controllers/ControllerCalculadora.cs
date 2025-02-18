using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAPII.Controllers;

public class ControllerCalculadora : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}