using Microsoft.AspNetCore.Mvc;
namespace RazorController.Controllers;
public class RazorController : Controller
{

    [HttpGet("view/razor")]


    public ViewResult List1()
    {

        return View("Index");
    }
}


