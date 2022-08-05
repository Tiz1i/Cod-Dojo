using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using formsub.Models;

namespace formsub.Controllers;

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
    [HttpPost("create")]

    public IActionResult Create(Submitter user)
    {
        if(ModelState.IsValid)
        {
            return RedirectToAction("Show");
        }
            return View("Index");
    }

    [HttpGet("show")]
    public ViewResult Show()
    {
        return View();
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
