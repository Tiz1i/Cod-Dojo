using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ushtmeflogertin.Models;

namespace ushtmeflogertin.Controllers;

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
   [HttpGet("Privacy")]
    public IActionResult Privacy()
    {
        return View();
    }
 
    [HttpPost("Create")]
    public ActionResult AdminApproval(string ApproveReject)
    {
        if (ApproveReject =="Approve")
        {
            return RedirectToAction("Privacy");
        }
        else if (ApproveReject =="Reject")
        {
            return RedirectToAction("SurveiMia");
        }
        return View();
    }   
    [HttpGet("Mia")]
     public IActionResult Mia()
    {
        return View();
    }
    [HttpPost("Survei")]
    public IActionResult THirrFormen(Survey Mia) 
    {
        
        return View("Mia", Mia);
    }

    [HttpGet("SurveiMia")]
     public IActionResult Survey()
        {
            
         return View("SurveiMia");
        }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
