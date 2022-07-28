using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dojosurvey2.Models;

namespace dojosurvey2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet("Tabela")]

      public IActionResult Tabela()
    {
        return View();
    }

    [HttpPost("Survey")]

    public IActionResult KetuTherrasFormen(Survey tabela)
    {
        
        return View("Privacy",tabela);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
