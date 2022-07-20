using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers;
public class HelloController : Controller
{

    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "This is my index!";
    }

    [HttpGet("projects")]
    public string Projects()
    {
        return "These are my projects!";
    }
     [HttpGet("projects/3")]
    public string Projects2()
    {
        return "These are my projects eshte 3!";
    }

    [HttpGet("contact")]
    public string Contact()
    {
        return "This is my contact!";
    }
}


