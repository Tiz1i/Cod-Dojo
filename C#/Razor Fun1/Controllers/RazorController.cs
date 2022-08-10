using Microsoft.AspNetCore.Mvc;
namespace RazorController.Controllers;
public class RazorController : Controller
{

    [HttpGet("view/razor")]


    public ViewResult List1()
    {

        return View("Index");
    }

    [Route("{firstnumber}/{secondnumber}")]
    public int numberss(int firstnumber, int secondnumber)
    {
        if (firstnumber > secondnumber)
        {

            return $"{firstnumber} eshte me i madh se {secondnumber}";

        }
        else if (firstnumber < secondnumber)
        {
            return $"{firstnumber} eshte me i vogel se {secondnumber}";

        }
        else
        {
            return $"numrat jane te barabarte";
        }
    }


