using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HarryMidterm.Models;
using HarryMidterm;

namespace HarryMidterm.Controllers;

public class CoopHomeController : Controller
{
    private readonly ILogger<CoopHomeController> _logger;

    public CoopHomeController(ILogger<CoopHomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
     public IActionResult CoopHome()
    {
        return View("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
