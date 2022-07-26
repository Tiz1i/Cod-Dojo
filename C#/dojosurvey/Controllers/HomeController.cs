using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;     //be sure to use your own project's namespace!
public class HomeController : Controller   //remember inheritance??
{
    //for each route this controller is to handle:
    [HttpGet]       //type of request
    [Route("")]     //associated route string (exclude the leading /)
    public ViewResult Home()
    {
        return View("Home");
    }



    // remember to use [HttpPost] attributes!
    [HttpPost]
    [Route("Result")]
    public IActionResult  Method(string Name, string Location,string Language,string Comment)
    {
        
        ViewBag.name=Name;
        ViewBag.location=Location;
        ViewBag.language = Language;
        ViewBag.comment = Comment;
        return View("Result");
    }
}