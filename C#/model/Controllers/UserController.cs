using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace Model.Controllers
{

    public class UserController : Controller
    {
        [HttpGet]
        [Route("")]

        public IActionResult UserDetail()
        {
            User someUser = new User()
            {
                FirstName = "Sally",
                LastName = "Sanderson"
            };
            ViewBag.User = "Sally";

            return View();
        }

        [HttpGet("Numbers")]

        public IActionResult Numbers()
        {

            int[] numbers = new int[]
            {
            1,
            2,
            3,
            10,
            43,
            5
            };

            return View(numbers);
        }

        [HttpGet("Klasa")]
        public IActionResult Klasa()
        {
            string[] klasa = new string[]
            {
            "Flogerti",
            "Alberto",
            "klodi",
            "eneso",
            "angela",
            "endi"
            };
            return View("Stringje", klasa);
        }

        [HttpGet("Message")]
        public IActionResult OneUser()
        {
            User firstUser = new User("Flogerti", "Alberto");
            return View("Message",firstUser);
        }

    }



}






// public class HomeController : Controller
// {
//     private readonly ILogger<HomeController> _logger;

//     public HomeController(ILogger<HomeController> logger)
//     {
//         _logger = logger;
//     }

//     public IActionResult Index()
//     {
//         return View();
//     }

//     public IActionResult Privacy()
//     {
//         return View();
//     }

//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }
