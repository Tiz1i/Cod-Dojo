using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;

    }
    public IActionResult Index()
    {
        ViewBag.Chefs = _context.Chefs.Include(e=>e.Dishes).ToList();
        return View("Chefs");
    }


    // controlleri qe ben return Viewn me listen e shefave
    [HttpGet("Chefs")]
    public IActionResult Chefs()
    {
        ViewBag.Chefs = _context.Chefs.ToList();
        return View();
    }


    // controlleri qe ben return Viewn me formen per krijimin e shefave
    [HttpGet("ChefAdd")]
    public IActionResult ChefAdd()
    {
        return View();
    }
    // controlleri qe merr formen e shefit nga View, e shton ne databaze dhe na ridrejton tek lista me shefat nes eshte valid
    // nes nuk eshte valid do na return Viewn ChefAdd ne menyre qe te na shfaqen validimet

    [HttpPost("createChef")]

    //vendosim emrin e modelit me nje emer cfaredo
    public IActionResult CreateChef(Chef currentChef){
        //kontrollojme validimet, nese jemi ok e rregjistrojme ne db dhe e cojme userin atje ku duam
    if(ModelState.IsValid){
        _context.Chefs.Add(currentChef);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }//nese kemi errore shfaq te njejten faqe per ta ribere prap
        return View("ChefAdd");
    }




    [HttpGet("Dishes")]
    public IActionResult Dish()
    {
        ViewBag.Dish = _context.Dishes.Include(e=>e.creator).ToList();
        return View();
    }


    [HttpGet("AddDish")]
    public IActionResult AddDish()
    {
        
        ViewBag.Chefs = _context.Chefs.ToList();
        return View();
    }
    
    [HttpPost("DishCreate")]

    //vendosim emrin e modelit me nje emer cfaredo
    public IActionResult DishCreate(Dish currentDish){
        //kontrollojme validimet, nese jemi ok e rregjistrojme ne db dhe e cojme userin atje ku duam
    if(ModelState.IsValid){
        _context.Dishes.Add(currentDish);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    //nese kemi errore shfaq te njejten faqe per ta ribere prap
    ViewBag.Chefs = _context.Chefs.ToList();
    return View("AddDish");
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
