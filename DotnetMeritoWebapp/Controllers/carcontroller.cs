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
        var carslists = new List<CarViewModel>();
        carslists.Add(new CarViewModel {Name = "GLA", Color = "White", Brand = "Mercedes"});
        carslists.Add(new CarViewModel {Name = "Tiguan", Color = "Beige", Brand = "Volkswagen"});
        carslists.Add(new CarViewModel {Name = "Cooper", Color = "Red", Brand = "Mini"});

        return View(carslists);
    }
}
