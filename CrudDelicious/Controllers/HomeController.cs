using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudDelicious.Models;

namespace CrudDelicious.Controllers;

public class HomeController : Controller
{
    private MyContext _context;
     
    // here we can "inject" our context service into the constructor
    public HomeController(MyContext context)
    {
        _context = context;
    }
     
    public IActionResult Index()
    {
        ViewBag.Mydishes = _context.Dishes.OrderBy(c=>c.CreatedAt);
        return View();
    }
    [HttpGet("Add")]
    public IActionResult Add(){
        return View();
    }

    [HttpPost("create")]

    public IActionResult Create (Dish marrngaAdd)
    {
        if(ModelState.IsValid)
        {
            _context.Add(marrngaAdd);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }else{
             return View("Add");
    
        }
       
    }

    [HttpGet("show/{id}")]
    public IActionResult Show(int id){
        // merr dish nga daatabasa ne baze te id 
     Dish thirrDish = _context.Dishes.Where(a => a.DishId == id).First();
     return View(thirrDish);
    }


    [HttpGet("Edit/{id}")]
    public IActionResult Edit(int id)
    {
        Dish OldDish = _context.Dishes.First(c=>c.DishId == id);
    
        return View("Edit", OldDish);
    }
    [HttpPost("Edit/Update/{id}")]
    public IActionResult Update(int id, Dish NewDish)
    {
        if(ModelState.IsValid)
        {
            // Olddish gjended ne DB
            // NewDish esht dish qe merret nga forma, pra nga Add.cshtml
            Dish OldDish = _context.Dishes.First(c=>c.DishId == id);
            OldDish.NameOfDish = NewDish.NameOfDish;
            OldDish.Calories= NewDish.Calories;
            OldDish.Descriptions= NewDish.Descriptions;
            OldDish.ChefsName = NewDish.ChefsName;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else{
            return View("Edit/{id}");
        }
        
    }

    [HttpGet("Delete/{id}")]

    public IActionResult Fshi (int id){
        Dish marrngaDb = _context.Dishes.First(e => e.DishId == id);
        _context.Dishes.Remove(marrngaDb);
        _context.SaveChanges();
        return RedirectToAction("Index");


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
