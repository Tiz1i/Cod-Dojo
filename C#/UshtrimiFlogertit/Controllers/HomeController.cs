using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UshtrimiFlogertit.Models;

namespace UshtrimiFlogertit.Controllers;

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

    [HttpPost("Search")]
    public String Search(string search){
        List<User> Perdoruesit = new List<User>();
        
        User user1 = new User(){
            Name = "flogert",
            LastName = "Ciku"
        };
        Perdoruesit.Add(user1);


        User user2 = new User(){
            Name = "test",
            LastName = "Ciku"
        };
        Perdoruesit.Add(user2);
        
        
        User user3 = new User(){
            Name = "test2",
            LastName = "Ciku"
        };
        Perdoruesit.Add(user3);

        foreach (User user in Perdoruesit)
        {
            if (user.Name == search)
            {
                return "u gjet useri";
            }
        }
        return "nuk u gjet";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
