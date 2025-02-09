using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotnetMeritoWebapp.Models;

namespace DotnetMeritoWebapp.Controllers;

public class CarController : Controller
{
    private readonly ILogger<CarController> _logger;

    public CarController(ILogger<CarController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}
