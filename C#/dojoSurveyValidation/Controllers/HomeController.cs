using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dojoSurveyValidation.Models;

namespace dojoSurveyValidation.Controllers;

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
    // In HomeController
    [HttpPost("user/create")]
    public IActionResult Create(User user)
    {
        if (ModelState.IsValid)
        {
            // do somethng!  maybe insert into db?  then we will redirect
            return RedirectToAction("Result");
        }
        else
        {
            // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
            return View("Add");
        }
    }
    [HttpPost("Result")]
    public IActionResult Result()
    {
        // While being hard-coded here, this user instance will eventually come from our DB
        User someUser = new User()
        {
            YourName = "Mia",
            DojoLocation = "Tirane",
           
        };
        // Here we pass this instance to our View
        return View("Result", someUser);
        // If we also need to include the name of our View, we pass our instance as a second argument
        // return View("OtherView", someUser);
     
    }
       






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
