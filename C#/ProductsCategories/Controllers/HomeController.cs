using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductsCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsCategories.Controllers;


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
        return View();
    }

    [HttpGet("Products")]
    public IActionResult Products()
    {
        ViewBag.AllProducts = _context.Products;
        return View();
    }

    [HttpPost("NewProduct")]
    public IActionResult NewProduct(Products MarrNgaView)
    {
        if(ModelState.IsValid)
        {
            _context.Products.Add(MarrNgaView);
            _context.SaveChanges();
            return RedirectToAction("Products");
        }
        else
        {
            return View("Products");
        }
    }

     [HttpGet("Product/{id}")]
    public IActionResult ProductId(int id)
    {
        ViewBag.ThisProduct = _context.Products.Include(c=>c.Associations).ThenInclude(c=>c.Category).First(c=>c.ProductId == id);
        ViewBag.SelectCategories = _context.Categories.Include(c=>c.Associations).Where(c=>c.Associations.Any(c=>c.ProductId == id) == false).ToList();

        return View();
    }

    [HttpGet("Categories")]
    public IActionResult Categories()
    {
        ViewBag.AllCategories = _context.Categories;
        return View();
    }
    [HttpPost("NewCategory")]
    public IActionResult NewCategory(Category MarrNgaView)
    {
        if(ModelState.IsValid)
        {
            _context.Categories.Add(MarrNgaView);
            _context.SaveChanges();
            return RedirectToAction("Categories");
        }
        else
        {
            return View("NewCategory");
        }
    }
    [HttpPost("/Product/AddCategory/{id}")]
    public IActionResult AddCategory(int id, SubmitCategory MarrNgaView)
    {
        Association Lidhja = new Association{
            ProductId = id,
            CategoryId = MarrNgaView.CategoryId
        };
        _context.Associations.Add(Lidhja);
        _context.SaveChanges();
        return RedirectToAction("Products");
    }

    [HttpGet("Category/{id}")]
    public IActionResult CategoryId(int id)
    {
        ViewBag.ThisCategory = _context.Categories.First(c => c.CategoryId == id);
        ViewBag.SelectProduct = _context.Products.Include(c=>c.Associations).Where(c=>c.Associations.Any(c=>c.CategoryId == id) == false).ToList();
        return View();
    }
    [HttpPost("/Category/Addproduct/{id}")]
    public IActionResult AddProduct(int id, SubmitProduct MarrNgaView)
    {
        Association Lidhja = new Association{
            ProductId = id,
            CategoryId = MarrNgaView.ProductId
        };
        _context.Associations.Add(Lidhja);
        _context.SaveChanges();
        return RedirectToAction("Categories");
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
